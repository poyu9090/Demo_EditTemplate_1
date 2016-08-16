using Refactor.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Refactor.Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            var Service = new POIService();
            var POIs = Service.Get(id);

            return Json(POIs,JsonRequestBehavior.AllowGet);
        }
    }
}
