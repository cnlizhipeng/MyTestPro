namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EidtModuleTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet");
            DropIndex("dbo.SYS_ModuleTables", new[] { "TableSetID" });
            AddColumn("dbo.SYS_ModuleTables", "FieldName", c => c.String(maxLength: 50));
            AddColumn("dbo.SYS_ModuleTables", "PFieldName", c => c.String(maxLength: 50));
            AlterColumn("dbo.SYS_ModuleTables", "TableSetID", c => c.Int(nullable: false));
            AlterColumn("dbo.SYS_ModuleTables", "DisplayType", c => c.String(maxLength: 50));
            CreateIndex("dbo.SYS_ModuleTables", "TableSetID");
            AddForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet");
            DropIndex("dbo.SYS_ModuleTables", new[] { "TableSetID" });
            AlterColumn("dbo.SYS_ModuleTables", "DisplayType", c => c.String());
            AlterColumn("dbo.SYS_ModuleTables", "TableSetID", c => c.Int());
            DropColumn("dbo.SYS_ModuleTables", "PFieldName");
            DropColumn("dbo.SYS_ModuleTables", "FieldName");
            CreateIndex("dbo.SYS_ModuleTables", "TableSetID");
            AddForeignKey("dbo.SYS_ModuleTables", "TableSetID", "dbo.SYS_TableSet", "ID");
        }
    }
}
