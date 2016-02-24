using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EFWCF.Models;
using System.Data.Entity.Infrastructure;
using System.Configuration;
using System.Data.Entity.ModelConfiguration;
namespace EFWCF.DAL
{
    public class BaseContext : DbContext
    {
        public BaseContext()
            : base(nameOrConnectionString: ConnectionString())
        //: base("Data Source=LI-PC;Initial Catalog=MyProject;Integrated Security=True")
        {
            //this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<BaseContext>(null);
            //Database.SetInitializer<BaseContext>(new DropCreateDatabaseAlways<BaseContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BaseContext>());
        }

        /// <summary>
        /// 通过代码方式，获取连接字符串的名称返回。
        /// </summary>
        /// <returns></returns>
        private static string ConnectionString()
        {
            //根据不同的数据库类型，构造相应的连接字符串名称
            string dbType = System.Configuration.ConfigurationManager.AppSettings["ComponentDbType"];
            if (string.IsNullOrEmpty(dbType))
            {
                dbType = "sqlserver";
            }

            return string.Format("name={0}", dbType.ToLower());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //属性中，属性名称是ID的定义为主键。
            //modelBuilder.Properties<int>()
            //            .Where(p => p.Name == "ID")
            //            .Configure(p => p.IsKey());
            
        }
        //public DbSet<B_ModuleTree> B_ModuleTree { get; set; }
        #region 用户管理部分
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RoleModule> RoleModules { get; set; }
        #endregion 
        #region 模块管理内容
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleTables> ModuleTables { get; set; }
        public DbSet<ModuleColumn> ModuleColumns { get; set; }
        public DbSet<TableSet> TableSets { get; set; }
        public DbSet<ColumnSet> ColumnSets { get; set; }
        public DbSet<FunctionSet> FunctionSets { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<DataDictionary> DataDictionarys { get; set; }
        public DbSet<MenuSet> MenuSets { get; set; }
        public DbSet<ModuleMenu> TableMenus { get; set; }
        public DbSet<DesktopLink> DesktopLinks { get; set; }
        #endregion

        public DbSet<MaterialBaseInfo> MaterialBaseInfos { get; set; }
    }
}
