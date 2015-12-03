using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_EditTemplate.Models.ViewModels
{
    public class CategoryViewModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public List<Product> productList { get; set; }
    }
}