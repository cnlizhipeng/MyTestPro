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
    public class ModulesMap
    {
        /// <summary>
        /// 模块管理映射
        /// </summary>
        public static void Execute()
        {
            Mapper.CreateMap<Module, ModuleDTO>();
            Mapper.CreateMap<ModuleDTO, Module>();

            //Mapper.CreateMap<ModuleTables, ModuleTablesDTO>()
            //    .ForMember(d => d.TableSetTableName, opt => opt.MapFrom(s => s.TableSet.TableCaption));
            Mapper.CreateMap<ModuleTables, ModuleTablesDTO>();
            Mapper.CreateMap<ModuleTablesDTO, ModuleTables>();

            Mapper.CreateMap<TableSet, TableSetDTO>();
            Mapper.CreateMap<TableSetDTO, TableSet>();

            Mapper.CreateMap<ColumnSet, ColumnSetDTO>();
            Mapper.CreateMap<ColumnSetDTO, ColumnSet>();

            Mapper.CreateMap<FunctionSet, FunctionSetDTO>();
            Mapper.CreateMap<FunctionSetDTO, FunctionSet>();

            Mapper.CreateMap<MenuSet, MenuSetDTO>();
            Mapper.CreateMap<MenuSetDTO, MenuSet>();

            Mapper.CreateMap<ModuleMenu, ModuleMenuDTO>();
            Mapper.CreateMap<ModuleMenuDTO, ModuleMenu>();

            Mapper.CreateMap<DesktopLink, DesktopLinkDTO>();
            Mapper.CreateMap<DesktopLinkDTO, DesktopLink>();
            //模组列关联表
            Mapper.CreateMap<ModuleColumn, ModuleColumnDTO>();

            Mapper.CreateMap<ModuleColumnDTO, ModuleColumn>();

        }
    }
}
