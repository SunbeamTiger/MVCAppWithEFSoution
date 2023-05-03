using DBProject.Context;
using DBProject.Models;
using Microsoft.AspNetCore.Mvc;
using MVCAppWithEF.Models;
using System.Diagnostics;

namespace MVCAppWithEF.Controllers
{
    public class HomeController : Controller
    {
      
        private GSContext _gsContext;
        public HomeController(GSContext context)
        {
            _gsContext = context;
        }

        public IActionResult Index()
        {
            List<Customer> Cust = _gsContext.Customers.ToList();
            return View(Cust);
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