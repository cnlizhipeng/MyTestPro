namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SYS_ColumnSet", "CanFilter", c => c.Boolean(nullable: false));
            AddColumn("dbo.SYS_ColumnSet", "IsReadOnly", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SYS_ColumnSet", "FixType", c => c.String(maxLength: 20));
            AlterColumn("dbo.SYS_ColumnSet", "PageFooterType", c => c.String(maxLength: 200));
            AlterColumn("dbo.SYS_ColumnSet", "GlobalFooterType", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SYS_ColumnSet", "GlobalFooterType", c => c.String());
            AlterColumn("dbo.SYS_ColumnSet", "PageFooterType", c => c.String());
            AlterColumn("dbo.SYS_ColumnSet", "FixType", c => c.String());
            DropColumn("dbo.SYS_ColumnSet", "IsReadOnly");
            DropColumn("dbo.SYS_ColumnSet", "CanFilter");
        }
    }
}
