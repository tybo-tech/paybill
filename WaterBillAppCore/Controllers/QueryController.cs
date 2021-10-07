using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WaterBillAppCore.Areas.Identity.Data;
using WaterBillAppCore.Models;

namespace WaterBillAppCore.Controllers
{
    public class QueryController : Controller
    {
        private readonly WaterAppContext _context;
        private readonly UserManager<AppUser> _userManager;
        public List<string> QueryTypes { get; set; }


        public QueryController(WaterAppContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        // GET: Query
        public async Task<IActionResult> Index()
        {
            return View(await _context.queries.ToListAsync());
        }

        // GET: Query/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var query = await _context.queries
                .FirstOrDefaultAsync(m => m.QueryId == id);
            if (query == null)
            {
                return NotFound();
            }

            return View(query);
        }

        // GET: Query/Create
        public async Task<IActionResult> Create()
        {
            var queryTypes = await _context.querytypes.ToListAsync();
            ViewBag.QueryTypes = new SelectList(queryTypes, "Name", "Name");
            return View();
        }

        // POST: Query/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QueryId,Description,Category,CustomerId,CustomerName,CustomerAddress,CustomerPhone,CustomerEmail,CreateDate,AcceptedDate,ClosedDate,LastModifiedDate")] Query query)
        {
            if (ModelState.IsValid)
            {
                var id = _userManager.GetUserId(HttpContext.User);
                AppUser appUser = _userManager.FindByIdAsync(id).Result;
                User user = _context.users.FirstOrDefault(x => x.UserEmail == appUser.Email);
                query.CustomerName = user.FirstName;
                query.CustomerName = user.FirstName;
                query.CustomerAddress = user.HomeAddress;
                query.CustomerEmail = user.UserEmail;
                query.CustomerPhone = user.PhoneNumber;
                query.CustomerId = user.UserId;
                query.QueryStatus = "New";
                query.CreateDate = DateTime.Now;
                query.AcceptedDate = DateTime.Now;
                query.ClosedDate = DateTime.Now;
                query.LastModifiedDate = DateTime.Now;
                _context.Add(query);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(query);
        }

        // GET: Query/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var query = await _context.queries.FindAsync(id);
            if (query == null)
            {
                return NotFound();
            }

            var queryTypes = await _context.querytypes.ToListAsync();
            //QueryTypes = queryTypes.Select(x => x.Name).ToList();
            ViewBag.QueryTypes = new SelectList(queryTypes, "Name", "Name");
            return View(query);
        }

        // POST: Query/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Query query)
        {
            if (id != query.QueryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var dbQuery = _context.queries.FirstOrDefault(x => x.QueryId == id);
                    dbQuery.Description = query.Description;
                    dbQuery.Category = query.Category;
                    _context.Update(dbQuery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QueryExists(query.QueryId))
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
            return View(query);
        }

        // GET: Query/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var query = await _context.queries
                .FirstOrDefaultAsync(m => m.QueryId == id);
            if (query == null)
            {
                return NotFound();
            }

            return View(query);
        }

        // POST: Query/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var query = await _context.queries.FindAsync(id);
            _context.queries.Remove(query);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QueryExists(int id)
        {
            return _context.queries.Any(e => e.QueryId == id);
        }
    }
}
