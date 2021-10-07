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
    public class VatsController : Controller
    {
        private readonly WaterAppContext _context;

        public VatsController(WaterAppContext context)
        {
            _context = context;
        }

        // GET: Vats
        public async Task<IActionResult> Index()
        {
            return View(await _context.vats.ToListAsync());
        }

        // GET: Vats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vat = await _context.vats
                .FirstOrDefaultAsync(m => m.SettingId == id);
            if (vat == null)
            {
                return NotFound();
            }

            return View(vat);
        }

        // GET: Vats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SettingId,VatPercetage")] Vat vat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vat);
        }

        // GET: Vats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vat = await _context.vats.FindAsync(id);
            if (vat == null)
            {
                return NotFound();
            }
            return View(vat);
        }

        // POST: Vats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SettingId,VatPercetage")] Vat vat)
        {
            if (id != vat.SettingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VatExists(vat.SettingId))
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
            return View(vat);
        }

        // GET: Vats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vat = await _context.vats
                .FirstOrDefaultAsync(m => m.SettingId == id);
            if (vat == null)
            {
                return NotFound();
            }

            return View(vat);
        }

        // POST: Vats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vat = await _context.vats.FindAsync(id);
            _context.vats.Remove(vat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VatExists(int id)
        {
            return _context.vats.Any(e => e.SettingId == id);
        }
    }
}
