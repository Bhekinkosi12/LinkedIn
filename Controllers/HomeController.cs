using LinkedIn.Models;
using LinkedIn.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LinkedIn.Services;
using Newtonsoft.Json;

namespace LinkedIn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        UserStore store = new UserStore();
      static string recentProfile { get; set; }
        UserViewModel model { get; set; } = new UserViewModel("1");
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
          
            
        }
        public IActionResult Login()
        {
            return View(model);
        }
        public IActionResult Index()
        {
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Statistics()
        {
            List<DataPoint> dataPoints1 = new List<DataPoint>();
            List<DataPoint> dataPoints2 = new List<DataPoint>();
            List<DataPoint> dataPoints3 = new List<DataPoint>();

            dataPoints1.Add(new DataPoint("Jan", 72));
            dataPoints1.Add(new DataPoint("Feb", 67));
            
            dataPoints1.Add(new DataPoint("Mar", 55));
            dataPoints1.Add(new DataPoint("Apr", 42));
            dataPoints1.Add(new DataPoint("May", 40));
            dataPoints1.Add(new DataPoint("Jun", 35));
           

            dataPoints2.Add(new DataPoint("Jan", 48));
            dataPoints2.Add(new DataPoint("Feb", 56));
            dataPoints2.Add(new DataPoint("Mar", 50));
            dataPoints2.Add(new DataPoint("Apr", 47));
            dataPoints2.Add(new DataPoint("May", 65));
            dataPoints2.Add(new DataPoint("Jun", 69));

            dataPoints3.Add(new DataPoint("Jan", 38));
            dataPoints3.Add(new DataPoint("Feb", 46));
            dataPoints3.Add(new DataPoint("Mar", 55));
            dataPoints3.Add(new DataPoint("Apr", 70));
            dataPoints3.Add(new DataPoint("May", 77));
            dataPoints3.Add(new DataPoint("Jun", 91));

            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);


            model = new UserViewModel(recentProfile);
            return View(model);
        }

        public ActionResult ProfileClick(string profile)
        {
            recentProfile = profile;
            model = new UserViewModel(profile);
            return View("Index",model);
        }
        public ActionResult LikeClick(string likes)
        {
          //  store.setLike(likes);
            model = new UserViewModel(recentProfile,int.Parse(likes));
            return View("Index",model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
