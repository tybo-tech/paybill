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
    public class UserController : Controller
    {
        private readonly Models.WaterAppContext _context;

        public UserController(Models.WaterAppContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.users.ToListAsync());
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public async Task<IActionResult>  AddOrEdit(int id = 0)
        {
            var userTypes = await _context.usertypes.ToListAsync();
            ViewBag.UserTypes = new SelectList(userTypes, "Name", "Name");
            if (id == 0) 
             return View(new User());
            else
                return View(_context.users.Find(id));
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("UserId,FirstName,LastName,UserEmail,HomeAddress,Password,UserType,CreatedDate,LastModifiedDate,UserStatus")] User user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserId == 0)
                {
                    user.AccountNumber = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
                    user.UserStatus = "Active";
                    user.UserStatus = "Active";
                    user.HomeAddress = "";
                    user.Password = "";
                    user.CreatedDate = DateTime.Now.ToString();
                    user.LastModifiedDate = DateTime.Now.ToString();
                    _context.Add(user);
                }
                else {
                    if (string.IsNullOrWhiteSpace(user.AccountNumber)) {
                        user.AccountNumber = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
                    }
                    _context.Update(user);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

     

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FirstName,LastName,UserEmail,HomeAddress,Password,UserType,CreatedDate,LastModifiedDate,UserStatus")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
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
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.users.FindAsync(id);
            _context.users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.users.Any(e => e.UserId == id);
        }
    }
}
