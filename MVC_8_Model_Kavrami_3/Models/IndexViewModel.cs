using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_8_Model_Kavrami_3.Models
{
    public class IndexViewModel
    {
        public List<Category> kategorilerim { get; set; }
        public List<Product> urunlerim { get; set; }
    }
}