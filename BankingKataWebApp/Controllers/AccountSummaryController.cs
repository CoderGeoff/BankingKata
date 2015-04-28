using System;
using System.Web.Mvc;
using BankingKataWebApp.ViewModels;

namespace BankingKataWebApp.Controllers
{
    public class AccountSummaryController : Controller
    {
        public ActionResult Index()
        {
            // You wil need to fetch the appropriate data via another object here

            // The View requires objects of this shape
            var viewModel = new AccountSummaryViewModel
            {
                LastTransactionDate = new DateTime(2015, 3, 31),
                LastTransactionAmount = 32.50m,
                CurrentBalance = 1050.42m
            };

            return View(viewModel);
        }
    }
}