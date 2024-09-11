using Microsoft.AspNetCore.Mvc;

namespace BTVN02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Trần Trọng Thanh ";
            ViewBag.MSSV = " 1822041609";
            ViewBag.Nam = "Năm 2024";
            return View();
        }
    }
}
