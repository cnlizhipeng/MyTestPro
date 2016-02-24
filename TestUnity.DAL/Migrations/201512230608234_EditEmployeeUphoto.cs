namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditEmployeeUphoto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HR_Employee", "UPhoto", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HR_Employee", "UPhoto", c => c.Binary());
        }
    }
}
