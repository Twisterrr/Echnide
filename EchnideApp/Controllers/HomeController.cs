using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EchnideApp.Models;
using Microsoft.AspNetCore.Identity;
using EchnideApp.Data;

namespace EchnideApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UserManager<IdentityUser> _manager;
        ApplicationDbContext _appContext;

        public HomeController(ILogger<HomeController> logger,
                                UserManager<IdentityUser> manager)
        {
            _manager = manager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register(RegisterModel model)
        {
            var newUser = new IdentityUser<string>
            {
                Id = Guid.NewGuid().ToString(),
                UserName = Guid.NewGuid().ToString(),
            };
            _manager.CreateAsync(newUser as IdentityUser, model.Password);
            

            // _appContext.Add(new IdentityUser<string>{
            //     Id = Guid.NewGuid().ToString(),
            //     PasswordHash = 
            // })

            return Ok();
        }
    }
}
