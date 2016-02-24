using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
using EFWCF.DTO;
using System.Reflection;
using AutoMapper;
namespace EFWCF.DTO
{
    public class InitialMapper
    {
        public static void Execute()
        {
            //利用反射加载DTO中类的内容，比对Model中的名称进行加载，如果Mapping 类下没有特殊定义，就按Convention判断加载
            Assembly abDto = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory+"bin\\EFWCF.DTO.dll");
            Assembly abModel = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "bin\\EFWCF.Models.dll");
            Assembly adMapping = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "bin\\EFWCF.Mapping.dll");
            foreach (Type dtoT in abDto.GetTypes())
            {
                //如果基类是DTOBase的就继续加载
                if (dtoT.Name.Contains("DTO"))
                {
                    string name = dtoT.Name.Replace("DTO", "");
                    string mapName = dtoT.Name.Replace("DTO", "Map");
                    Type modelT = abModel.GetType("EFWCF.Models." + name);
                    //模型有相对应的实体
                    if (modelT != null)
                    {
                        Type mapT = adMapping.GetType("EFWCF.Mapping." + mapName);
                        //是否有特殊的对应设置关系
                        if (mapT != null)
                        {
                            //ConstructorInfo ciMap = mapT.GetConstructor(new Type[] { });
                            //IMapping imap = (IMapping)ciMap.Invoke(null);
                            //imap.Execute();
                        }
                        else
                        {
                             //Mapper.CreateMap(dtoT, modelT).
                             //    IgnoreAllPropertiesWithAnInaccessibleSetter().
                             //    IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                            Mapper.CreateMap(typeof(User), typeof(UserDTO));
                        }
                    }
                }
            }
            //try
            //{
            //    AutoMapper.Mapper.AssertConfigurationIsValid();
            //}
            //catch
            //{
            //    throw new InvalidOperationException();
            //}
        }
    }
}
