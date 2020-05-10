using MVC_8_Model_Kavrami_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_8_Model_Kavrami_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NORTHWND db = new NORTHWND();
            List<Category> katList = db.Categories.ToList();
            List<Product> urunList = db.Products.Take(30).ToList(); // 30 tanesini alarak listeler.
            IndexViewModel vm = new IndexViewModel();
            vm.kategorilerim = katList;
            vm.urunlerim = urunList;
            return View(vm);
        }
    }
}
// Index sayfasında hem kategorileri hem de ürünleri listeleyelim.