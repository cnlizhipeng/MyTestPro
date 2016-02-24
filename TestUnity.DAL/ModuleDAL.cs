using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.IDAL;
using EFWCF.Models;
namespace EFWCF.DAL
{
    public class ModuleDAL : BaseDAL<Module>, IModuleDAL
    {
        BaseContext userContext;
        public ModuleDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class ModuleTablesDAL : BaseDAL<ModuleTables>, IModuleTablesDAL
    {
        BaseContext userContext;
        public ModuleTablesDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class ModuleColumnDAL : BaseDAL<ModuleColumn>, IModuleColumnDAL
    {
        BaseContext userContext;
        public ModuleColumnDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class TableSetDAL : BaseDAL<TableSet>, ITableSetDAL
    {
        BaseContext userContext;
        public TableSetDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class ColumnSetDAL : BaseDAL<ColumnSet>, IColumnSetDAL
    {
        BaseContext userContext;
        public ColumnSetDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class FunctionSetDAL : BaseDAL<FunctionSet>, IFunctionSetDAL
    {
        BaseContext userContext;
        public FunctionSetDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class MenuSetDAL : BaseDAL<MenuSet>, IMenuSetDAL
    {
        BaseContext userContext;
        public MenuSetDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
    public class TableMenuDAL : BaseDAL<ModuleMenu>, IModuleMenuDAL
    {
        BaseContext userContext;
        public TableMenuDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
    public class DesktopLinkDAL : BaseDAL<DesktopLink>, IDesktopLinkDAL
    {
        BaseContext userContext;
        public DesktopLinkDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class ModuleMenuDAL : BaseDAL<ModuleMenu>, IModuleMenuDAL
    {
        BaseContext userContext;
        public ModuleMenuDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
}
