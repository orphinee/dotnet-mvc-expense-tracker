using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_expense_tracker.Controllers
{
    public class BudgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
