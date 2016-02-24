namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.INV_MaterialBaseInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaterialName = c.String(maxLength: 200),
                        MaterialNo = c.String(maxLength: 200),
                        MaterialUnit = c.String(maxLength: 200),
                        MaterialModel = c.String(maxLength: 200),
                        MaterialPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.SYS_ModuleTables", "ViewOrder", c => c.Int(nullable: false));
            DropColumn("dbo.SYS_ModuleTables", "NewTableCap");
            DropColumn("dbo.SYS_ModuleTables", "DisplayType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SYS_ModuleTables", "DisplayType", c => c.String(maxLength: 50));
            AddColumn("dbo.SYS_ModuleTables", "NewTableCap", c => c.String(maxLength: 50));
            DropColumn("dbo.SYS_ModuleTables", "ViewOrder");
            DropTable("dbo.INV_MaterialBaseInfo");
        }
    }
}
