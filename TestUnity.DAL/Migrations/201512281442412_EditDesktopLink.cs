namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDesktopLink : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SYS_DesktopLink",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ModuleID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Module", t => t.ModuleID, cascadeDelete: true)
                .ForeignKey("dbo.SYS_User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ModuleID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.SYS_MenuSet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PID = c.Int(nullable: false),
                        MenuType = c.String(),
                        MenuCaption = c.String(),
                        MenuImage = c.String(),
                        EventName = c.String(),
                        EventParameter = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SYS_TableMenu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuSetID = c.Int(nullable: false),
                        TableSetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_MenuSet", t => t.MenuSetID, cascadeDelete: true)
                .ForeignKey("dbo.SYS_TableSet", t => t.TableSetID, cascadeDelete: true)
                .Index(t => t.MenuSetID)
                .Index(t => t.TableSetID);
            
            AddColumn("dbo.SYS_TableSet", "GearedModuleName", c => c.String(maxLength: 100));
            AddColumn("dbo.SYS_TableSet", "ServiceSvcName", c => c.String(maxLength: 100));
            AddColumn("dbo.SYS_TableSet", "ServiceInterface", c => c.String(maxLength: 100));
            AddColumn("dbo.SYS_TableSet", "Binding", c => c.String(maxLength: 30));
            AddColumn("dbo.SYS_TableSet", "GZipTransform", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SYS_TableMenu", "TableSetID", "dbo.SYS_TableSet");
            DropForeignKey("dbo.SYS_TableMenu", "MenuSetID", "dbo.SYS_MenuSet");
            DropForeignKey("dbo.SYS_DesktopLink", "UserID", "dbo.SYS_User");
            DropForeignKey("dbo.SYS_DesktopLink", "ModuleID", "dbo.SYS_Module");
            DropIndex("dbo.SYS_TableMenu", new[] { "TableSetID" });
            DropIndex("dbo.SYS_TableMenu", new[] { "MenuSetID" });
            DropIndex("dbo.SYS_DesktopLink", new[] { "UserID" });
            DropIndex("dbo.SYS_DesktopLink", new[] { "ModuleID" });
            DropColumn("dbo.SYS_TableSet", "GZipTransform");
            DropColumn("dbo.SYS_TableSet", "Binding");
            DropColumn("dbo.SYS_TableSet", "ServiceInterface");
            DropColumn("dbo.SYS_TableSet", "ServiceSvcName");
            DropColumn("dbo.SYS_TableSet", "GearedModuleName");
            DropTable("dbo.SYS_TableMenu");
            DropTable("dbo.SYS_MenuSet");
            DropTable("dbo.SYS_DesktopLink");
        }
    }
}
