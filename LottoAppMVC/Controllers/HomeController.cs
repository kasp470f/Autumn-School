using LottoAppMVC.Models;
using LottoClassLibrary.Coupons;
using LottoClassLibrary.Coupons.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LottoAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        private Coupon temp;
        [HttpPost]
        public IActionResult Index(string type, string amount, string rows, bool joker)
        {
            if (!int.TryParse(amount, out _) || !int.TryParse(rows, out _)) return View();
            int CouponAmounts = int.Parse(amount);
            int CouponRows = int.Parse(rows);
            ViewBag.Coupons = new List<Coupon>();
            for (int i = 0; i < CouponAmounts; i++)
            {
                if (type == "Lotto") temp = new LottoCoupon(CouponRows);
                if (type == "Viking") temp = new VikingCoupon(CouponRows);
                if (joker) temp.AddJokers();
                ViewBag.Coupons.Add(temp);
            }
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
    }
}
