namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SYS_ModuleMenu", "MenuType", c => c.String());
            AddColumn("dbo.SYS_ModuleMenu", "MenuCaption", c => c.String());
            AddColumn("dbo.SYS_ModuleMenu", "MenuImage", c => c.String());
            AddColumn("dbo.SYS_ModuleMenu", "EventName", c => c.String());
            AddColumn("dbo.SYS_ModuleMenu", "EventParameter", c => c.String());
            AddColumn("dbo.SYS_ModuleMenu", "ViewOrder", c => c.Int(nullable: false));
            AddColumn("dbo.SYS_ModuleMenu", "BeginGroup", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SYS_ModuleMenu", "BeginGroup");
            DropColumn("dbo.SYS_ModuleMenu", "ViewOrder");
            DropColumn("dbo.SYS_ModuleMenu", "EventParameter");
            DropColumn("dbo.SYS_ModuleMenu", "EventName");
            DropColumn("dbo.SYS_ModuleMenu", "MenuImage");
            DropColumn("dbo.SYS_ModuleMenu", "MenuCaption");
            DropColumn("dbo.SYS_ModuleMenu", "MenuType");
        }
    }
}
