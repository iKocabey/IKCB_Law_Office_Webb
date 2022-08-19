namespace DataAcceessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_tblDosyalar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblDosyalars", "dosyaDurum", c => c.String(maxLength: 10));
            AlterColumn("dbo.tblDosyalars", "davaDurum", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblDosyalars", "davaDurum", c => c.Boolean(nullable: false));
            AlterColumn("dbo.tblDosyalars", "dosyaDurum", c => c.Boolean(nullable: false));
        }
    }
}
