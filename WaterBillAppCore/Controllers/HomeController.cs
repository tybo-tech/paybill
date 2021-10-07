using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WaterBillAppCore.Areas.Identity.Data;
using WaterBillAppCore.Models;

namespace WaterBillAppCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly Models.WaterAppContext _context;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, WaterAppContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;

        }

        [AllowAnonymous]

        public IActionResult Index()
        {
            var id = _userManager.GetUserId(HttpContext.User);
            if (id != null)
            {
                AppUser appUser = _userManager.FindByIdAsync(id).Result;
                if (appUser != null) { 
                User user = _context.users.FirstOrDefault(x=>x.UserEmail == appUser.Email);
                    if (user != null)
                    {
                        return Redirect("Home/" + user.UserType);
                    }
                    else
                    {
                        //Create a new user.
                        user = new User()
                        {
                            FirstName = appUser.FirstName,
                            LastName = appUser.LastName,
                            UserEmail = appUser.Email,
                            UserType = "Customer",
                            UserStatus = "Active",
                            HomeAddress = "",
                            Password = "",
                            CreatedDate = DateTime.Now.ToString(),
                            LastModifiedDate = DateTime.Now.ToString()
                        };
                        _context.users.Add(user);
                        _context.SaveChanges();
                        return Redirect("Home/" + user.UserType);
                    }
                }
               
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Customer()
        {
            return View();
        }

        public IActionResult Agent()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
