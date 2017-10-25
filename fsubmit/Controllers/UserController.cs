using fsubmit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fsubmit.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View("~/Views/User/Register.cshtml");
        }
        [HttpPost]
        [Route ("registering")]
        public IActionResult Register(Register user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", user);
            }
            else{
                ViewBag.errors = ModelState.Values;
                return View("~/Views/User/Register.cshtml", user);
            }
        }
        [HttpGet]
        [Route("return")]
        public IActionResult Return()
        {
            return View("~/Views/User/Login.cshtml");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Login user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", user);
            }
            else{
                ViewBag.errors = ModelState.Values;
                return View("~/Views/User/Register.cshtml", user);
            }
        }

        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            return View("~/Views/User/Success.cshtml");
        }
    }
}