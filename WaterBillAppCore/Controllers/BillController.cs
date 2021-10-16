using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using WaterBillAppCore.Helpers;
using WaterBillAppCore.Models;
using WaterBillAppCore.ViewModel;

namespace WaterBillAppCore.Controllers
{
    public class BillController : Controller
    {
        private readonly WaterAppContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _hostingEnviroment;


        public BillController(WaterAppContext context, UserManager<AppUser> userManager, IHostingEnvironment hostingEnviroment)
        {
            _context = context;
            _userManager = userManager;
            _hostingEnviroment = hostingEnviroment;
          
        }

        // GET: Bill
        [HttpGet]
        public async Task<IActionResult> Index(string searchTerm)
        {
            ViewData["GetData"] = searchTerm;
            var bills = await _context.bills.ToListAsync();

            var id = _userManager.GetUserId(HttpContext.User);
           
            if (id != null)
            {
                AppUser appUser = _userManager.FindByIdAsync(id).Result;
                if (null != appUser)
                {
                    if (await _userManager.IsInRoleAsync(appUser, "Customer"))
                        bills = bills.Where(x => x.CustomerId == id).ToList();
                }
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.Trim();
                bills = bills
                        .Where(x => (x.CustomerName ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.AccountNumber ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.CustomerAddress ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.CustomerEmail ?? "").ToLower().Contains(searchTerm.ToLower())
                        )
                        .ToList();
            }
            return View(bills);
        }



        // GET: Bill/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.bills
                .FirstOrDefaultAsync(m => m.BillId == id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }

        // GET: Bill/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Bill/Create
        public async Task<IActionResult> Confirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.bills
                .FirstOrDefaultAsync(m => m.BillId == id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }   
        
        // GET: Bill/Create
        public async Task<IActionResult> BillPaid(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.bills
                .FirstOrDefaultAsync(m => m.BillId == id);
            if (bill == null)
            {
                return NotFound();
            }

            bill.AmountPaid = bill.Amount;
            bill.BillStatus = "Paid";
            bill.LastModifiedDate = DateTime.Now;
            _context.bills.Update(bill);
            _context.SaveChanges();
            return View(bill);
        }

        // POST: Bill/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BillViewModel model)
        {
            var bill = new Bill();

            if (ModelState.IsValid)
            {
                string fileName = "";
                if (model.Photo != null) {
                  string uploadsFolder =  Path.Combine(_hostingEnviroment.WebRootPath, "images");
                    fileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                   string filePath = Path.Combine(uploadsFolder, fileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

                }
                var id = _userManager.GetUserId(HttpContext.User);
                var appUser = await _userManager.FindByIdAsync(id);
                bill.CustomerName = appUser.FirstName;
                bill.PrevReading = model.PrevReading;
                bill.CurrentReading = model.CurrentReading;
                bill.CustomerName = appUser.FirstName;
                bill.CustomerAddress = appUser.HomeAddress;
                bill.CustomerEmail = appUser.Email;
                bill.CustomerPhone = appUser.PhoneNumber;
                bill.CustomerId = appUser.Id;
                bill.AccountNumber = appUser.AccountNumber;
                bill.PhotoUrl = fileName;
                bill.BillStatus = "Pending Payment";
                bill.Description = "Water usage bill";
                bill.CreatedDate = DateTime.Now;

                var charge = _context.settings.FirstOrDefault().ChargeRate;
                var usage = bill.CurrentReading - bill.PrevReading;
                bill.Usage = usage;
                bill= getTotalCharge(bill);
                _context.Add(bill);
                await _context.SaveChangesAsync();

                var users = new List<string>();
                foreach (var user in _userManager.Users.ToList())
                {

                    if (await _userManager.IsInRoleAsync(user, "Admin"))
                    {
                        users.Add(user.Email);
                    }


                }

                if (users.Any())
                {
                    var emailHelper = new EmailHelper();
                    emailHelper.SendMail($"{bill.CustomerName} Create a new Bill of R{bill.Amount}. ", "New Bill"
                        , users.ToArray());
                }
 

                return Redirect("Confirm/" + bill.BillId);
            }
            return View(bill);
        }

        // GET: Bill/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.bills.FindAsync(id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

        // POST: Bill/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BillId,CustomerId,CustomerName,CustomerAddress,CustomerPhone,CustomerEmail,BillNo,Amount,AmountPaid,PaymentDate,DueDate,CreatedDate,LastModifiedDate,BillStatus,PrevReading,CurrentReading,Usage")] Bill bill)
        {
            if (id != bill.BillId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bill.LastModifiedDate = DateTime.Now;
                    _context.Update(bill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BillExists(bill.BillId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bill);
        }

        // GET: Bill/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.bills
                .FirstOrDefaultAsync(m => m.BillId == id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }

        // POST: Bill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bill = await _context.bills.FindAsync(id);
            _context.bills.Remove(bill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BillExists(int id)
        {
            return _context.bills.Any(e => e.BillId == id);
        }

        private Bill getTotalCharge(Bill bill) {
            double charge = 0;
            var rate = _context.settings.FirstOrDefault(x=> bill.Usage >= x.RangeStart && bill.Usage <= x.RangeFinish);
            if (rate != null) { 
                charge = bill.Usage * rate.ChargeRate;
            }

            var vat = _context.vats.FirstOrDefault();
            if (vat != null) {
                bill.Amount = charge + charge * (vat.VatPercetage / 100.0);
              
            }
            //var rate = rates.
            return bill;
        }

  

    }
}
