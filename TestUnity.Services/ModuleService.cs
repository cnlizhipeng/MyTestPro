using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
using EFWCF.DTO;
using EFWCF.IServices;
using EFWCF.BLL;
using EFWCF.Common;
namespace EFWCF.Services
{
    public class ModuleService : ServiceBase<ModuleDTO, Module>, IModuleService
    {
        public ModuleService()
        {
            base.BaseBLL = new ModuleBLL();
        }
    }

    public class ModuleTablesService : ServiceBase<ModuleTablesDTO, ModuleTables>, IModuleTablesService
    {
        public ModuleTablesService()
        {
            base.BaseBLL = new ModuleTablesBLL();
        }

        public IList<ModuleTablesDTO> GetTableWithModuleID(int moduleid)
        {
            PropertyMatch pm = new PropertyMatch("ModuleID", new List<string>() { moduleid.ToString() }, typeof(int).FullName);
            return GetListMatch(new List<PropertyMatch>() { pm }, null);
        }
    }

    public class ModuleColumnService : ServiceBase<ModuleColumnDTO, ModuleColumn>, IModuleColumnService
    {
        public ModuleColumnService()
        {
            base.BaseBLL = new ModuleColumnBLL();
        }

        public IList<ModuleColumnDTO> Insert(int tableid, int moduleid)
        {
            //List<ModuleColumn> lste=BaseBLL.GetListMatch(a=>a.ModuleID==moduleid && a.t
            return null;
        }
    }

    public class TableSetService : ServiceBase<TableSetDTO, TableSet>, ITableSetService
    {
        public TableSetService()
        {
            base.BaseBLL = new TableSetBLL();
        }
    }

    public class ColumnSetService : ServiceBase<ColumnSetDTO, ColumnSet>, IColumnSetService
    {
        public ColumnSetService()
        {
            base.BaseBLL = new ColumnSetBLL();
        }

        public IList<ColumnSetDTO> GetTableColumn(int tableid)
        {
            PropertyMatch pm = new PropertyMatch("TableID", new List<string>() { tableid.ToString() }, typeof(int).FullName);
            return GetListMatch(new List<PropertyMatch>() { pm }, null);
        }
    }

    public class MenuSetService : ServiceBase<MenuSetDTO, MenuSet>, IMenuSetService
    {
        public MenuSetService()
        {
            base.BaseBLL = new MenuSetBLL();
        }
    }
    public class ModuleMenuService : ServiceBase<ModuleMenuDTO, ModuleMenu>, IModuleMenuService
    {
        public ModuleMenuService()
        {
            base.BaseBLL = new ModuleMenuBLL();
        }

        IList<ModuleMenuDTO> IModuleMenuService.InitialMenu(int moduleid)
        {
            MenuSetBLL bll = new MenuSetBLL();
            base.BaseBLL.DeleteEntity(a => a.ModuleID == moduleid);
            List<MenuSet> lstentity = bll.GetQueryable(null).ToList();
            foreach (MenuSet ms in lstentity)
            {
                ModuleMenu mm = new ModuleMenu();
                mm.BeginGroup = ms.BeginGroup;
                mm.EventName = ms.EventName;
                mm.EventParameter = ms.EventParameter;
                mm.MenuCaption = ms.MenuCaption;
                mm.MenuImage = ms.MenuImage;
                mm.MenuType = ms.MenuType;
                mm.ViewOrder = ms.ViewOrder;
                mm.ModuleID = moduleid;
                mm.MenuSetID = ms.ID;
                mm.MenuSetPID = ms.PID;
                BaseBLL.InsertEntity(mm);
            }

            return GetMenuWithModuleID(moduleid);
        }

        public IList<ModuleMenuDTO> GetMenuWithModuleID(int moduleid)
        {
            List<ModuleMenuDTO> lstDto = new List<ModuleMenuDTO>();
            IEnumerable<ModuleMenu> q = this.BaseBLL.GetQueryableMatch(a => a.ModuleID == moduleid, null).ToList();
            foreach (ModuleMenu et in q)
            {
                ModuleMenuDTO addDto = new ModuleMenuDTO();
                addDto.FetchValuesFromEntity<ModuleMenu>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }
    }
    public class DesktopLinkService : ServiceBase<DesktopLinkDTO, DesktopLink>, IDesktopLinkService
    {
        public DesktopLinkService()
        {
            base.BaseBLL = new DesktopLinkBLL();
        }

        public IList<DesktopLinkDTO> GetUserLink(int userid)
        {
            List<DesktopLinkDTO> lstDto = new List<DesktopLinkDTO>();
            IEnumerable<DesktopLink> q = base.BaseBLL.GetQueryableMatch(a => a.UserID == userid, null).ToList();
            foreach (DesktopLink et in q)
            {
                DesktopLinkDTO addDto = new DesktopLinkDTO();
                addDto.FetchValuesFromEntity<DesktopLink>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }
        public override DesktopLinkDTO InsertEntity(DesktopLinkDTO d)
        {
            DesktopLink e = new DesktopLink();
            d.AssignValuesToEntity<DesktopLink>(e);

            DesktopLink addE = this.BaseBLL.InsertEntity(e);
            if (addE != null)
            {
                d.FetchValuesFromEntity<DesktopLink>(addE);
                return d;
            }
            else
                return null;
        }
    }
    public class FunctionSetService : ServiceBase<FunctionSetDTO, FunctionSet>, IFunctionSetService
    {
        public FunctionSetService()
        {
            base.BaseBLL = new FunctionSetBLL();
        }
    }
}
