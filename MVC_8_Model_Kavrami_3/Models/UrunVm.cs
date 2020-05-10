using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_8_Model_Kavrami_3.Models
{
    public class UrunVm
    {
        public UrunVm() // ctor
        {
            NORTHWND db = new NORTHWND();
            this.ucuz_urunler = db.Products.OrderBy(x => x.UnitPrice).Take(5).ToList();
            this.pahali_urunler = db.Products.OrderByDescending(x => x.UnitPrice).Skip(5).Take(5).ToList();
            this.az_urunler = db.Products.OrderBy(x => x.UnitsInStock).Take(10).ToList();
        }
        public List<Product> ucuz_urunler { get; set; }
        public List<Product> pahali_urunler { get; set; }
        public List<Product> az_urunler { get; set; }
    }
}