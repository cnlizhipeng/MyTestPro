using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EFWCF.DTO;
namespace EFWCF.IServices
{
    [ServiceContract]
    public interface IModuleService : IServiceBase<ModuleDTO>
    {

    }

    [ServiceContract]
    public interface IModuleTablesService : IServiceBase<ModuleTablesDTO>
    {
        [OperationContract]
        IList<ModuleTablesDTO> GetTableWithModuleID(int moduleid);
    }
    [ServiceContract]
    public interface IModuleColumnService : IServiceBase<ModuleColumnDTO>
    {
        IList<ModuleColumnDTO> Insert(int tableid, int moduleid);
    }
    [ServiceContract]
    public interface ITableSetService : IServiceBase<TableSetDTO>
    {

    }
    [ServiceContract]
    public interface IColumnSetService : IServiceBase<ColumnSetDTO>
    {
        [OperationContract]
        IList<ColumnSetDTO> GetTableColumn(int tableid);
    }
    [ServiceContract]
    public interface IFunctionSetService : IServiceBase<FunctionSetDTO>
    {

    }
    [ServiceContract]
    public interface IMenuSetService : IServiceBase<MenuSetDTO>
    {

    }
    [ServiceContract]
    public interface IModuleMenuService : IServiceBase<ModuleMenuDTO>
    {
        [OperationContract]
        IList<ModuleMenuDTO> InitialMenu(int moduleid);
        [OperationContract]
        IList<ModuleMenuDTO> GetMenuWithModuleID(int moduleid);
    }
    [ServiceContract]
    public interface IDesktopLinkService : IServiceBase<DesktopLinkDTO>
    {
        [OperationContract]
        IList<DesktopLinkDTO> GetUserLink(int userid);
    }
}
