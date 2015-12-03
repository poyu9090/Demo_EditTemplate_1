using Demo_EditTemplate.Models;
using Demo_EditTemplate.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_EditTemplate.Controllers
{
    public class DynamicController : Controller
    {
        public ActionResult Index()
        {
            var model = new CategoryViewModel
            {
                id = Guid.NewGuid(),
                name = "書籍",
                productList = new List<Product>
                {
                    new Product
                    {
                        id = Guid.NewGuid(),
                        name = "碧血劍"
                    },
                    new Product
                    {
                        id = Guid.NewGuid(),
                        name = "魯蛇傳奇"
                    },
                    new Product
                    {
                        id = Guid.NewGuid(),
                        name = "X戰警之庵是金鋼朗"
                    }
                }
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CategoryViewModel model)
        {
            return View(model);
        }
    }
}