using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWCF.MVC.Controllers
{
    public class DisplayStringController : Controller
    {
        //
        // GET: /DisplayString/

        public ActionResult Index()
        {
           
            ViewBag.Message = "我要呈现的内容页";
            return View();
        }

    }
}
