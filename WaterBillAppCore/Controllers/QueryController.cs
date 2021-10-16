using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index(string searchTerm)
        {
            ViewData["GetData"] = searchTerm;
            var results = await _context.queries.ToListAsync();
            var id = _userManager.GetUserId(HttpContext.User);
            if (id != null)
            {
                AppUser appUser = _userManager.FindByIdAsync(id).Result;
                if (null != appUser)
                {
                    if (await _userManager.IsInRoleAsync(appUser, "Customer"))
                        results = results.Where(x => x.CustomerId == id).ToList();
                }
            }
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.Trim();
                results = results
                        .Where(x => (x.CustomerAddress ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.AccountNumber ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.CustomerName ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.CustomerEmail ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.Description ?? "").ToLower().Contains(searchTerm.ToLower())
                        || (x.Category ?? "").ToLower().Contains(searchTerm.ToLower())
                        ).ToList();
                        ;
            }
            return View(results);
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
            var userId = _userManager.GetUserId(HttpContext.User);
            AppUser appUser = _userManager.FindByIdAsync(userId).Result;
            if (appUser != null)
            {
                ViewBag.User = appUser;
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
        public async Task<IActionResult> Create(Query query)
        {
            if (ModelState.IsValid)
            {
                var id = _userManager.GetUserId(HttpContext.User);
                AppUser appUser = _userManager.FindByIdAsync(id).Result;
                query.CustomerName = appUser.FirstName;
                query.CustomerName = appUser.FirstName;
                query.CustomerAddress = appUser.HomeAddress;
                query.CustomerEmail = appUser.Email;
                query.AccountNumber = appUser.AccountNumber;
                query.CustomerPhone = appUser.PhoneNumber;
                query.CustomerId = appUser.Id;
                query.AddressUrl = appUser.AddressUrl;
                query.QueryStatus = "New";
                query.CreateDate = DateTime.Now;
                query.AcceptedDate = DateTime.Now;
                query.ClosedDate = DateTime.Now;
                query.LastModifiedDate = DateTime.Now;
                try
                {
                    _context.queries.Add(query);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {

                    throw;
                }
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


        // GET: Query/Edit/5
        public async Task<IActionResult> UpdateStatus(int? id)
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
        public async Task<IActionResult> UpdateStatus(int id, Query query)
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


                    if (dbQuery.QueryStatus == "In Progress")
                    {
                        dbQuery.QueryStatus = "Closed";
                        dbQuery.ClosedDate = DateTime.Now;

                    }
                    if (dbQuery.QueryStatus == "Accepted")
                    {
                        dbQuery.QueryStatus = "In Progress";
                    }


                  
                    if (dbQuery.QueryStatus == "New") {
                        dbQuery.QueryStatus = "Accepted";
                        dbQuery.AcceptedDate = DateTime.Now;
                    }

                  
                  


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
