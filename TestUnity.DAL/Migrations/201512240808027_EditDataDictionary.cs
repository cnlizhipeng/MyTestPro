namespace EFWCF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDataDictionary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SYS_DataDictionary", "CodeValue", c => c.String(maxLength: 400));
            AlterColumn("dbo.SYS_DataDictionary", "PYM", c => c.String(maxLength: 100));
            AlterColumn("dbo.SYS_DataDictionary", "PYJM", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SYS_DataDictionary", "PYJM", c => c.String());
            AlterColumn("dbo.SYS_DataDictionary", "PYM", c => c.String());
            DropColumn("dbo.SYS_DataDictionary", "CodeValue");
        }
    }
}
