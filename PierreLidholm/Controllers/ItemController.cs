using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PierreLidholm.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Item1()
        {
            return View();
        }

        public IActionResult Item2()
        {
            return View();
        }

        public IActionResult Item3()
        {
            return View();
        }
    }
}