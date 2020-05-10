using MVC_8_Model_Kavrami_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_8_Model_Kavrami_3.Controllers
{
    public class UrunController : Controller
    {
        public ActionResult UrunleriGetir()
        {
            UrunVm vm = new UrunVm();
            return View(vm);
        }
    }
}
// En ucuz ve en pahalı ürünleri gösterelim.