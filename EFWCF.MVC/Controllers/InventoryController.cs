using EFWCF.Common;
using EFWCF.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWCF.MVC.Controllers
{
    public class InventoryController : Controller
    {
        //
        // GET: /Inventory/

        public ActionResult Index()
        {
            return View();
        }

        public string GetJson()
        {

            //MaterialBaseInfoService mbisc = new MaterialBaseInfoService();
            //PagerInfo p = new PagerInfo();
            //p.CurrentPage=1;
            //p.DataCount=15;
            //p.PageCount=30;
            //p.PageDataCount=30;
            //var lstResult = mbisc.GetListPage(null, ref p,null);
            //JArray json = new JArray(from r in lstResult
            //                         select new JObject(
            //                             new JProperty("id", r.ID),
            //                             new JProperty("MaterialName", r.MaterialName),
            //                             new JProperty("MaterialNo", r.MaterialNo),
            //                             new JProperty("MaterialUnit", r.MaterialUnit),
            //                             new JProperty("MaterialModel", r.MaterialModel),
            //                             new JProperty("MaterialPrice", r.MaterialPrice)
            //                             ));
            //return json.ToString();
            return "";
        }
    }
}
