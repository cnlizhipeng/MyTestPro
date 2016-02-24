using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
namespace EFWCF.BLL
{
    public class FactoryDAL
    {
        protected static object syncObject = new object();

        protected static FactoryDAL m_Instance = null;

        public IUnityContainer Container { get; set; }
        public static FactoryDAL Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (syncObject)
                    {
                        if (m_Instance == null)
                        {
                            
                            m_Instance = new FactoryDAL();
                            m_Instance.Container = new UnityContainer();
                            //注册关联关系
                            //m_Instance.Container.RegisterType<ISystemUserDAL, SystemUserDAL>();
                            //m_Instance.Container.RegisterType<DbContext, BaseContext>();
                            //m_Instance.Container.LoadConfiguration("containerOne");
                            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                            section.Configure(m_Instance.Container, "containerOne");
                        }
                    }
                }
                return m_Instance;
            }
        }
    }
}
