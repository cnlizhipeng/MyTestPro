namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataDictionary : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HR_Employee", "OrganizationID", "dbo.SYS_Organization");
            DropIndex("dbo.HR_Employee", new[] { "OrganizationID" });
            CreateTable(
                "dbo.SYS_DataDictionary",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PID = c.Int(nullable: false),
                        DictionaryName = c.String(nullable: false, maxLength: 100),
                        ViewOrder = c.Int(nullable: false),
                        PYM = c.String(),
                        PYJM = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.HR_Employee", "OrganizationID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HR_Employee", "OrganizationID", c => c.Int(nullable: false));
            DropTable("dbo.SYS_DataDictionary");
            CreateIndex("dbo.HR_Employee", "OrganizationID");
            AddForeignKey("dbo.HR_Employee", "OrganizationID", "dbo.SYS_Organization", "ID", cascadeDelete: true);
        }
    }
}
