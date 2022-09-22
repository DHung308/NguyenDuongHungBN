using Microsoft.AspNetCore.Mvc;
using NguyenDuongHungBTH.Models;
using NguyenDuongHungBTH.models.Process;

namespace NguyenDuongHungBTH.Controllers
{
    public class DemoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public IActionResult Index()
        {
            return View();
        }
        //nhan duoc du lieu tu View gui len
        [HttpPost]
        public IActionResult Index( string heSoA, string heSoB )
        {
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string thongBao  = gpt.GiaiPhuongTrinhBacNhat(a,b);
            ViewBag.message = thongBao;
            return View();
        }
        [HttpPost]
      public IActionResult Creat(string heSoA, string heSoB, string heSoC)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        double c = Convert.ToDouble(heSoC);
        string thongBao = gpt.GiaiPhuongTrinhBacHai(a, b, c);
        ViewBag.mess= thongBao ; 
        return View();
      }
    }
}   