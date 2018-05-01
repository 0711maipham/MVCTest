using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string FirstName, string LastName, int SocialSecurity, string PhoneNumber)
        {

            ViewData["FirstName"] = FirstName;
            ViewData["LastName"] = LastName;
            ViewData["SocialSecurity"] = SocialSecurity;
            ViewData["PhoneNumber"] = PhoneNumber;
            return View();
        }

        public float Fibonacci()
    {
        float[] fib = new float[101];
        fib[0] = 0;
        fib[1] = 1;

        for (int i = 2; i <= 100; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        ViewData["FiboAnswer"] = fib[100];
        return fib[100];
    }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
