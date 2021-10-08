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
using WaterBillAppCore.Areas.Identity.Data;
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
        public async Task<IActionResult> Index()
        {
            return View(await _context.bills.ToListAsync());
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
                AppUser appUser = _userManager.FindByIdAsync(id).Result;
                User user = _context.users.FirstOrDefault(x => x.UserEmail == appUser.Email);
                bill.CustomerName = user.FirstName;
                bill.PrevReading = model.PrevReading;
                bill.CurrentReading = model.CurrentReading;
                bill.CustomerName = user.FirstName;
                bill.CustomerAddress = user.HomeAddress;
                bill.CustomerEmail = user.UserEmail;
                bill.CustomerPhone = user.PhoneNumber;
                bill.CustomerId = user.UserId;
                bill.AccountNumber = user.AccountNumber;
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

        private void SendMail(string body, string subject)
        {
            var message = new MimeMessage();
            var admin = _context.users.FirstOrDefault(x=>x.UserType == "Admin");
            if (admin != null) {
                message.From.Add(new MailboxAddress("Bill Created", "noreply@ipay.co.za"));
                message.To.Add(new MailboxAddress("Bill Created", admin.UserEmail));
                message.To.Add(new MailboxAddress("Bill Created", "mrnnmthembu@gmail.com"));
                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body};
                using (var client = new SmtpClient()) {
                    client.Connect("smtp@gmail.com", 587, false);
                    client.Authenticate("noreply@ipay.co.za","v");
                    client.Send(message);
                        }
            }
          
        }

    }
}
