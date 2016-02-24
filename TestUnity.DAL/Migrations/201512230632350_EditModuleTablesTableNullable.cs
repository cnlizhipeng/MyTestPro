namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleTablesTableNullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet");
            DropIndex("dbo.SYS_ModuleTables", new[] { "TableSetID" });
            AlterColumn("dbo.SYS_ModuleTables", "TableSetID", c => c.Int());
            CreateIndex("dbo.SYS_ModuleTables", "TableSetID");
            AddForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet");
            DropIndex("dbo.SYS_ModuleTables", new[] { "TableSetID" });
            AlterColumn("dbo.SYS_ModuleTables", "TableSetID", c => c.Int(nullable: false));
            CreateIndex("dbo.SYS_ModuleTables", "TableSetID");
            AddForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet", "ID", cascadeDelete: true);
        }
    }
}
