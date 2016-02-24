namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditEmployeeAndModule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HR_Employee", "UPhoto", c => c.Binary());
            AddColumn("dbo.SYS_Module", "ModuleImage", c => c.String());
            AddColumn("dbo.SYS_Module", "ModuleType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SYS_Module", "ModuleType");
            DropColumn("dbo.SYS_Module", "ModuleImage");
            DropColumn("dbo.HR_Employee", "UPhoto");
        }
    }
}
