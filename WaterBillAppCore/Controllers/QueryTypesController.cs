using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WaterBillAppCore.Models;

namespace WaterBillAppCore.Controllers
{
    public class QueryTypesController : Controller
    {
        private readonly WaterAppContext _context;

        public QueryTypesController(WaterAppContext context)
        {
            _context = context;
        }

        // GET: QueryTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.querytypes.ToListAsync());
        }

        // GET: QueryTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var queryType = await _context.querytypes
                .FirstOrDefaultAsync(m => m.QueryTypeId == id);
            if (queryType == null)
            {
                return NotFound();
            }

            return View(queryType);
        }

        // GET: QueryTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QueryTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QueryType queryType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(queryType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(queryType);
        }

        // GET: QueryTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var queryType = await _context.querytypes.FindAsync(id);
            if (queryType == null)
            {
                return NotFound();
            }
            return View(queryType);
        }

        // POST: QueryTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QueryTypeId,Name")] QueryType queryType)
        {
            if (id != queryType.QueryTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(queryType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QueryTypeExists(queryType.QueryTypeId))
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
            return View(queryType);
        }

        // GET: QueryTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var queryType = await _context.querytypes
                .FirstOrDefaultAsync(m => m.QueryTypeId == id);
            if (queryType == null)
            {
                return NotFound();
            }

            return View(queryType);
        }

        // POST: QueryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var queryType = await _context.querytypes.FindAsync(id);
            _context.querytypes.Remove(queryType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QueryTypeExists(int id)
        {
            return _context.querytypes.Any(e => e.QueryTypeId == id);
        }
    }
}
