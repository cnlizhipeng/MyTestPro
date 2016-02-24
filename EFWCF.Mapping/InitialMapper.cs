using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
using EFWCF.DTO;
using System.Reflection;
using AutoMapper;
namespace EFWCF.Mapping
{
    public class InitialMapper
    {
        public static void Execute()
        {
            AccountMap.Execute();
            ModulesMap.Execute();
            DataDictionaryMap.Execute();
            InventoryMap.Execute();
        }
    }
}
