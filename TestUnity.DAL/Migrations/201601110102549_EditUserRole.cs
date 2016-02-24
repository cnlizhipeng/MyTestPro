namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditUserRole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SYS_RoleModule",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CanVisible = c.Boolean(nullable: false),
                        CanUserMenu = c.Boolean(nullable: false),
                        ModuleID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Module", t => t.ModuleID, cascadeDelete: true)
                .ForeignKey("dbo.SYS_Role", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.ModuleID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.SYS_Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 50),
                        Remarks = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SYS_UserRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Role", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("dbo.SYS_User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SYS_UserRole", "UserID", "dbo.SYS_User");
            DropForeignKey("dbo.SYS_UserRole", "RoleID", "dbo.SYS_Role");
            DropForeignKey("dbo.SYS_RoleModule", "RoleID", "dbo.SYS_Role");
            DropForeignKey("dbo.SYS_RoleModule", "ModuleID", "dbo.SYS_Module");
            DropIndex("dbo.SYS_UserRole", new[] { "UserID" });
            DropIndex("dbo.SYS_UserRole", new[] { "RoleID" });
            DropIndex("dbo.SYS_RoleModule", new[] { "RoleID" });
            DropIndex("dbo.SYS_RoleModule", new[] { "ModuleID" });
            DropTable("dbo.SYS_UserRole");
            DropTable("dbo.SYS_Role");
            DropTable("dbo.SYS_RoleModule");
        }
    }
}
