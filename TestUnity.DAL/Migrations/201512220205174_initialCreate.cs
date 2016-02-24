namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SYS_ModuleTables", "FunctionSetID", "dbo.SYS_FunctionSet");
            DropForeignKey("dbo.SYS_Module", "TableSetID", "dbo.SYS_TableSet");
            DropIndex("dbo.SYS_Module", new[] { "TableSetID" });
            DropIndex("dbo.SYS_ModuleTables", new[] { "FunctionSetID" });
            AddColumn("dbo.SYS_ModuleTables", "PID", c => c.Int(nullable: false));
            AddColumn("dbo.SYS_ModuleTables", "TableSetID", c => c.Int(nullable: false));
            CreateIndex("dbo.SYS_ModuleTables", "TableSetID");
            AddForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet", "ID", cascadeDelete: true);
            AddForeignKey("dbo.SYS_ModuleTables", "ModuleID", "dbo.SYS_Module", "ID", cascadeDelete: true);
            DropColumn("dbo.SYS_Module", "TableSetID");
            DropColumn("dbo.SYS_ModuleTables", "FunctionSetID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SYS_ModuleTables", "FunctionSetID", c => c.Int(nullable: false));
            AddColumn("dbo.SYS_Module", "TableSetID", c => c.Int());
            DropForeignKey("dbo.SYS_ModuleTables", "ModuleID", "dbo.SYS_Module");
            DropForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet");
            DropIndex("dbo.SYS_ModuleTables", new[] { "TableSetID" });
            DropColumn("dbo.SYS_ModuleTables", "TableSetID");
            DropColumn("dbo.SYS_ModuleTables", "PID");
            CreateIndex("dbo.SYS_ModuleTables", "FunctionSetID");
            CreateIndex("dbo.SYS_Module", "TableSetID");
            AddForeignKey("dbo.SYS_Module", "TableSetID", "dbo.SYS_TableSet", "ID");
            AddForeignKey("dbo.SYS_ModuleTables", "FunctionSetID", "dbo.SYS_FunctionSet", "ID", cascadeDelete: true);
        }
    }
}
