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
    public interface IUserService : IServiceBase<UserDTO>
    {
        [OperationContract]
        UserDTO CanLogin(string uname, string pwd);
        [OperationContract]
        IList<UserDTO> GetUserList();
    }
    [ServiceContract]
    public interface IEmployeeService : IServiceBase<EmployeeDTO>
    {
 
    }


    [ServiceContract]
    public interface IUserTestService : IServiceBase<UserDTO>
    {
        [OperationContract]
        UserDTO CanLogin(string uname, string pwd);
        [OperationContract]
        IList<UserDTO> GetUserList();
    }
}
