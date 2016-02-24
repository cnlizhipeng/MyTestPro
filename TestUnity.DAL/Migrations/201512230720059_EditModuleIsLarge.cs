namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModuleIsLarge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SYS_Module", "IsLarge", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SYS_Module", "IsLarge");
        }
    }
}
