using AutoMapper;
using EFWCF.DTO;
using EFWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.Mapping
{
    public class InventoryMap
    {
        public static void Execute()
        {
            Mapper.CreateMap<MaterialBaseInfo, MaterialBaseInfoDTO>();
            Mapper.CreateMap<MaterialBaseInfoDTO, MaterialBaseInfo>();
        }
    }
}
