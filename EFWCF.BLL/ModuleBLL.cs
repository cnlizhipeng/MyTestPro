using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
using EFWCF.IDAL;
using Microsoft.Practices.Unity;
namespace EFWCF.BLL
{
    public class ModuleBLL : BaseBLL<Module>
    {
        IModuleDAL dal;
        public ModuleBLL()
        {
            dal = base.BaseContainer.Resolve<IModuleDAL>();
            base.BaseDAL = dal;
        }

        public ModuleBLL(IModuleDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }

    public class ModuleTablesBLL : BaseBLL<ModuleTables>
    {
        IModuleTablesDAL dal;
        public ModuleTablesBLL()
        {
            dal = base.BaseContainer.Resolve<IModuleTablesDAL>();
            base.BaseDAL = dal;
        }

        public ModuleTablesBLL(IModuleTablesDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }

    public class ModuleColumnBLL : BaseBLL<ModuleColumn>
    {
        IModuleColumnDAL dal;
        public ModuleColumnBLL()
        {
            dal = base.BaseContainer.Resolve<IModuleColumnDAL>();
            base.BaseDAL = dal;
        }

        public ModuleColumnBLL(IModuleColumnDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }

    public class TableSetBLL : BaseBLL<TableSet>
    {
        ITableSetDAL dal;
        public TableSetBLL()
        {
            dal = base.BaseContainer.Resolve<ITableSetDAL>();
            base.BaseDAL = dal;
        }

        public TableSetBLL(ITableSetDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }

    public class ColumnSetBLL : BaseBLL<ColumnSet>
    {
        IColumnSetDAL dal;
        public ColumnSetBLL()
        {
            dal = base.BaseContainer.Resolve<IColumnSetDAL>();
            base.BaseDAL = dal;
        }

        public ColumnSetBLL(IColumnSetDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }

    public class FunctionSetBLL : BaseBLL<FunctionSet>
    {
        IFunctionSetDAL dal;
        public FunctionSetBLL()
        {
            dal = base.BaseContainer.Resolve<IFunctionSetDAL>();
            base.BaseDAL = dal;
        }

        public FunctionSetBLL(IFunctionSetDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }

    public class MenuSetBLL : BaseBLL<MenuSet>
    {
        IMenuSetDAL dal;
        public MenuSetBLL()
        {
            dal = base.BaseContainer.Resolve<IMenuSetDAL>();
            base.BaseDAL = dal;
        }

        public MenuSetBLL(IMenuSetDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }
    public class ModuleMenuBLL : BaseBLL<ModuleMenu>
    {
        IModuleMenuDAL dal;
        public ModuleMenuBLL()
        {
            dal = base.BaseContainer.Resolve<IModuleMenuDAL>();
            base.BaseDAL = dal;
        }

        public ModuleMenuBLL(IModuleMenuDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }
    public class DesktopLinkBLL : BaseBLL<DesktopLink>
    {
        IDesktopLinkDAL dal;
        public DesktopLinkBLL()
        {
            dal = base.BaseContainer.Resolve<IDesktopLinkDAL>();
            base.BaseDAL = dal;
        }

        public DesktopLinkBLL(IDesktopLinkDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }
}
