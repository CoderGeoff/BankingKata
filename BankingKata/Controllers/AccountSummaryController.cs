using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingKata.Controllers
{
    public class AccountSummaryController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.LastTransactionDate = new DateTime(2015, 3, 31).ToString("f");
            ViewBag.LastTransactionAmount = 32.50.ToString("c2");
            ViewBag.CurrentBalance = 1050.42.ToString("c2");
            return View();
        }
    }
}