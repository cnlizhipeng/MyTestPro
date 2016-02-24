namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleControlTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SYS_Module", "ControlTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SYS_Module", "ControlTypeName");
        }
    }
}
