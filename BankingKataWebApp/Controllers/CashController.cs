using System.Web.Mvc;
using BankingKataWebApp.ViewModels;

namespace BankingKataWebApp.Controllers
{
    public class CashController : Controller
    {
        [HttpPost]
        public ActionResult Deposit(FormCollection values)
        {
            return View(new DepositCashViewModel() {Successful = true});
        }
    }
}