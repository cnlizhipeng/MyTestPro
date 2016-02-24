using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFWCF.DTO;
using EFWCF.Models;
namespace EFWCF.Mapping
{
    public class AccountMap
    {
        /// <summary>
        /// 用户访问映射
        /// </summary>
        public static void Execute()
        {
            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<UserDTO, User>();

            Mapper.CreateMap<Employee, EmployeeDTO>();
            Mapper.CreateMap<EmployeeDTO, Employee>();
        }
    }
}
