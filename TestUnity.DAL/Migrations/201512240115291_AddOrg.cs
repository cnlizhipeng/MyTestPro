namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SYS_Organization",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PID = c.Int(nullable: false),
                        OrgName = c.String(nullable: false, maxLength: 50),
                        OrgType = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.HR_Employee", "OrganizationID", c => c.Int(nullable: true));
            CreateIndex("dbo.HR_Employee", "OrganizationID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HR_Employee", "OrganizationID", "dbo.SYS_Organization");
            DropIndex("dbo.HR_Employee", new[] { "OrganizationID" });
            DropColumn("dbo.HR_Employee", "OrganizationID");
            DropTable("dbo.SYS_Organization");
        }
    }
}
