using EFWCF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWCF.MVC.Controllers
{
    public class SharedController : Controller
    {
        //
        // GET: /Shared/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModuleMenu(string modulename,int id)
        {
            //ModuleMenuService mmsc = new ModuleMenuService();
            //var result = mmsc.GetMenuWithModuleID(id);
            //return View(result);
            return null;
        }
    }
}
