using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedIn.Controllers
{
    public class AutheticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
