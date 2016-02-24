
using System;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using EFWCF.Services;
using EFWCF.DTO;

namespace EFWCF.MVC.Controllers
{
    public class HomeController : Controller
    {
        //SessionManagementCallback SessionCallback { get; set; }
        //InstanceContext SessionInstanceContext { get; set; }
        //SessionManagement.SessionManagementClient SessionManagementClient { get; set; }
        ////
        //// GET: /Home/
        //public HomeController()
        //{
        //    SessionCallback = new SessionManagementCallback();
        //    SessionInstanceContext = new InstanceContext(SessionCallback);
        //    SessionManagementClient = new SessionManagement.SessionManagementClient(SessionInstanceContext);
        //}
        public ActionResult Index()
        {
            ModuleService msc = new ModuleService();
            var q = msc.GetList(null);
            return View(q);
        }

        public ActionResult GetPageMenu(int id)
        {
            ModuleService msc = new ModuleService();
            var lstmodule = msc.GetSingleWithKeys(id);
            return PartialView("GetPageMenu", lstmodule);
        }

        public string GetModule(int id)
        {
            ModuleService msc = new ModuleService();
            var lstmodule = msc.GetList(null);
            var findp = from q in lstmodule
                        where q.PID == id
                        orderby q.ViewOrder
                        select q;
            List<ModuleDTO> lstResult = new List<ModuleDTO>();
            foreach (var item in findp)
            {
                lstResult.Add(item);
                GetModuleSon(ref lstResult, lstmodule, item.ID);
            }
            JArray json = new JArray(from r in lstResult
                                     select new JObject(
                                         new JProperty("id", r.ID),
                                         new JProperty("parentId", r.PID),
                                         new JProperty("name", r.ModuleCNName),
                                         new JProperty("url","/Inventory/Index")
                                         ));
            return json.ToString();
        }

        private void GetModuleSon(ref List<ModuleDTO> lst, IEnumerable<ModuleDTO> source, int pid)
        {
            var findp = from q in source
                        where q.PID == pid
                        orderby q.ViewOrder
                        select q;
            foreach (var item in findp)
            {
                lst.Add(item);
                GetModuleSon(ref lst, source, item.ID);
            }
        }
        //public ActionResult SendMessage(string msg)
        //{
        //    try
        //    {
        //        MessageInfo m = new MessageInfo();
        //        m.MsgButtons = MessageBoxButtons.OK;
        //        m.MsgIco = MessageBoxIcon.Information;
        //        m.MsgInfo = msg;
        //        m.MsgTitle = "来自网页的消息";
        //        m.MsgType = MessageInfo.MessageType.Alert;
        //        var q = SessionManagementClient.GetActiveSessions();
        //        SessionManagementClient.SendMessage(m, q.ToArray());
        //    }
        //    catch
        //    {
        //        return Content("发送失败");
        //    }
        //    return Content("发送成功");
        //}

        //[HttpPost]
        //public ActionResult TestAjax()
        //{
        //    return Content("TestAjax 传回的消息!");
        //}
    }
}
