using fsubmit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fsubmit.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route ("method")]
        public IActionResult Method(string fname, string lname, string age, string email, string password)
        {
            System.Console.WriteLine(fname);
            System.Console.WriteLine(age);            
            System.Console.WriteLine(password);
            System.Console.WriteLine(email);
            int iAge = Convert.ToInt32(age);
            User NewUser = new User{
                FirstName = fname,
                LastName = lname,
                Age = iAge,
                Email = email,
                Password = password,
            };
            bool trying = TryValidateModel(NewUser);
            if(trying)
            {
                return RedirectToAction("Success");
            }
            else{
                ViewBag.errors = ModelState.Values;
                return View("~/Views/Users/Index.cshtml");
            }
        }
        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            return View("~/Views/Users/Success.cshtml");
        }
    }
}