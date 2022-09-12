using Microsoft.AspNetCore.Mvc;
using NguyenDuongHungBTH.Models;

namespace NguyenDuongHungBTH.Controllers
{
    public class EmployeeController : Controller
    {
        // Viết các phương thức
        public IActionResult Index( Employee std)
        {
            ViewBag.Ep = std.EmployeeID +"-"+ std.EmployeeName +"-"+ std.EmployeeAddress;
       
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
    
}