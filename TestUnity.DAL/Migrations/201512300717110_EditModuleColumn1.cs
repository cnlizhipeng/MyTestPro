namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleColumn1 : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.SYS_TableMenu", newName: "SYS_ModuleMenu");
            //DropForeignKey("dbo.SYS_ModuleColumn", "TableSetID", "dbo.SYS_TableSet");
            //DropIndex("dbo.SYS_ModuleColumn", new[] { "TableSetID" });
            AddColumn("dbo.SYS_ColumnSet", "FixType", c => c.String());
            //DropColumn("dbo.SYS_ModuleColumn", "TableSetID");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.SYS_ModuleColumn", "TableSetID", c => c.Int(nullable: false));
            //DropColumn("dbo.SYS_ColumnSet", "FixType");
            //CreateIndex("dbo.SYS_ModuleColumn", "TableSetID");
            //AddForeignKey("dbo.SYS_ModuleColumn", "TableSetID", "dbo.SYS_TableSet", "ID", cascadeDelete: true);
            //RenameTable(name: "dbo.SYS_ModuleMenu", newName: "SYS_TableMenu");
        }
    }
}
