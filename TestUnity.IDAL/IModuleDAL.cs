using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.IDAL
{
    public interface IModuleDAL : IBaseDAL<Models.Module>
    {

    }
    public interface IModuleTablesDAL : IBaseDAL<Models.ModuleTables>
    {

    }
    public interface IModuleColumnDAL : IBaseDAL<Models.ModuleColumn>
    {

    }
    public interface ITableSetDAL : IBaseDAL<Models.TableSet>
    {

    }
    public interface IColumnSetDAL : IBaseDAL<Models.ColumnSet>
    {
        
    }
    public interface IFunctionSetDAL : IBaseDAL<Models.FunctionSet>
    {

    }

    public interface IMenuSetDAL : IBaseDAL<Models.MenuSet>
    {

    }
    public interface IModuleMenuDAL : IBaseDAL<Models.ModuleMenu>
    {

    }
    public interface IDesktopLinkDAL : IBaseDAL<Models.DesktopLink>
    {

    }
}
