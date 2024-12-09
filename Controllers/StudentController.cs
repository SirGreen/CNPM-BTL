using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryManagementDemo.Data;
using InventoryManagementDemo.Models;

namespace InventoryManagementDemo.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }

        public IActionResult PrintHistory()
        {
            return View();
        }

        public IActionResult BuyPage()
        {
            return View();
        }

        public IActionResult StartPrint()
        {
            return View();
        }

        public IActionResult PageConfig()
        {
            return View();
        }

        public IActionResult Stats()
        {
            return View();
        }
    }
}