namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleColumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SYS_TableMenu", "MenuSetID", "dbo.SYS_MenuSet");
            DropForeignKey("dbo.SYS_TableMenu", "TableSetID", "dbo.SYS_TableSet");
            DropIndex("dbo.SYS_TableMenu", new[] { "TableSetID" });
            DropTable("SYS_ModuleColumn");
            CreateTable(
                "dbo.SYS_ModuleColumn",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FieldOrder = c.Int(nullable: false),
                        VisibleEnable = c.Boolean(nullable: false),
                        PageFooterType = c.String(),
                        GlobalFooterType = c.String(),
                        ModuleID = c.Int(nullable: false),
                        ColumnSetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_ColumnSet", t => t.ColumnSetID, cascadeDelete: true)
                .ForeignKey("dbo.SYS_Module", t => t.ModuleID, cascadeDelete: true)
                .Index(t => t.ModuleID)
                .Index(t => t.ColumnSetID);
            
            CreateTable(
                "dbo.SYS_ModuleMenu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ModuleID = c.Int(nullable: false),
                        MenuSetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_MenuSet", t => t.MenuSetID, cascadeDelete: true)
                .ForeignKey("dbo.SYS_Module", t => t.ModuleID, cascadeDelete: true)
                .Index(t => t.ModuleID);
            
            AddColumn("dbo.SYS_MenuSet", "ViewOrder", c => c.Int(nullable: false));
            AddColumn("dbo.SYS_MenuSet", "BeginGroup", c => c.Boolean(nullable: false));
            AddColumn("dbo.SYS_ModuleTables", "NewTableCap", c => c.String(maxLength: 50));
            AlterColumn("dbo.SYS_MenuSet", "MenuType", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SYS_MenuSet", "MenuCaption", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SYS_MenuSet", "MenuImage", c => c.String(maxLength: 50));
            AlterColumn("dbo.SYS_MenuSet", "EventName", c => c.String(maxLength: 200));
            AlterColumn("dbo.SYS_MenuSet", "EventParameter", c => c.String(maxLength: 200));
            DropTable("dbo.SYS_TableMenu");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SYS_TableMenu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuSetID = c.Int(nullable: false),
                        TableSetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.SYS_TableMenu", "ModuleID", "dbo.SYS_Module");
            DropForeignKey("dbo.SYS_TableMenu", "MenuSetID", "dbo.SYS_MenuSet");
            DropForeignKey("dbo.SYS_ModuleColumn", "TableSetID", "dbo.SYS_TableSet");
            DropForeignKey("dbo.SYS_ModuleColumn", "ModuleID", "dbo.SYS_Module");
            DropForeignKey("dbo.SYS_ModuleColumn", "ColumnSetID", "dbo.SYS_ColumnSet");
            DropIndex("dbo.SYS_TableMenu", new[] { "ModuleID" });
            DropIndex("dbo.SYS_ModuleColumn", new[] { "ColumnSetID" });
            DropIndex("dbo.SYS_ModuleColumn", new[] { "TableSetID" });
            DropIndex("dbo.SYS_ModuleColumn", new[] { "ModuleID" });
            AlterColumn("dbo.SYS_MenuSet", "EventParameter", c => c.String());
            AlterColumn("dbo.SYS_MenuSet", "EventName", c => c.String());
            AlterColumn("dbo.SYS_MenuSet", "MenuImage", c => c.String());
            AlterColumn("dbo.SYS_MenuSet", "MenuCaption", c => c.String());
            AlterColumn("dbo.SYS_MenuSet", "MenuType", c => c.String());
            DropColumn("dbo.SYS_ModuleTables", "NewTableCap");
            DropColumn("dbo.SYS_MenuSet", "BeginGroup");
            DropColumn("dbo.SYS_MenuSet", "ViewOrder");
            DropTable("dbo.SYS_TableMenu");
            DropTable("dbo.SYS_ModuleColumn");
            CreateIndex("dbo.SYS_TableMenu", "TableSetID");
            AddForeignKey("dbo.SYS_TableMenu", "TableSetID", "dbo.SYS_TableSet", "ID", cascadeDelete: true);
            AddForeignKey("dbo.SYS_TableMenu", "MenuSetID", "dbo.SYS_MenuSet", "ID", cascadeDelete: true);
        }
    }
}
