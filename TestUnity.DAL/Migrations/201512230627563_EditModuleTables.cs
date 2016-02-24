namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SYS_ModuleTables", "DisplayType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SYS_ModuleTables", "DisplayType");
        }
    }
}
