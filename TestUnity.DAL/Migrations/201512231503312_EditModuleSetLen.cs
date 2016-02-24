namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleSetLen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SYS_Module", "ModuleImage", c => c.String(maxLength: 200));
            AlterColumn("dbo.SYS_Module", "ModuleType", c => c.String(maxLength: 50));
            AlterColumn("dbo.SYS_Module", "ControlTypeName", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SYS_Module", "ControlTypeName", c => c.String());
            AlterColumn("dbo.SYS_Module", "ModuleType", c => c.String());
            AlterColumn("dbo.SYS_Module", "ModuleImage", c => c.String());
        }
    }
}
