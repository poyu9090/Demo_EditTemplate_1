using Refactor.Service;
using Refactor.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Refactor.Application.Controllers
{
    public class HomeController : Controller
    {
        IPOIService _POIService;
        public HomeController(IPOIService poiService)
        {
            //POIService改成依賴介面IPOIService
            //並且實體是由外部來決定，也就是所謂的依賴注入DI
            _POIService = poiService;
        }


        public ActionResult Index(string id)
        {
            //依賴外部注入的IPOIService介面
            var POIs = _POIService.Get(id);
            return Json(POIs,JsonRequestBehavior.AllowGet);
        }
    }
}
