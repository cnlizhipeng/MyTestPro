namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EidtModuleMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SYS_ModuleMenu", "MenuSetPID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SYS_ModuleMenu", "MenuSetPID");
        }
    }
}
