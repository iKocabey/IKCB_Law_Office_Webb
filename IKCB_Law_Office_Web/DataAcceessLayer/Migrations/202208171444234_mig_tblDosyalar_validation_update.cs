namespace DataAcceessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_tblDosyalar_validation_update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblDosyalars", "dosyaTuru", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblDosyalars", "davaVeyaTakipTuru", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblDosyalars", "mahkemeTuruVeyaTakipYolu", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblDosyalars", "mahkemeTuruAltKirilim", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblDosyalars", "leyhdeAleyhde", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblDosyalars", "tarafimiz", c => c.String(maxLength: 20));
            AlterColumn("dbo.tblDosyalars", "davaVeyaIcraKonusu", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblDosyalars", "dosyaDurum", c => c.String(maxLength: 20));
            AlterColumn("dbo.tblDosyalars", "davaDurum", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblDosyalars", "davaDurum", c => c.String(maxLength: 10));
            AlterColumn("dbo.tblDosyalars", "dosyaDurum", c => c.String(maxLength: 10));
            AlterColumn("dbo.tblDosyalars", "davaVeyaIcraKonusu", c => c.String(maxLength: 20));
            AlterColumn("dbo.tblDosyalars", "tarafimiz", c => c.String(maxLength: 10));
            AlterColumn("dbo.tblDosyalars", "leyhdeAleyhde", c => c.String(maxLength: 10));
            AlterColumn("dbo.tblDosyalars", "mahkemeTuruAltKirilim", c => c.String(maxLength: 20));
            AlterColumn("dbo.tblDosyalars", "mahkemeTuruVeyaTakipYolu", c => c.String(maxLength: 20));
            AlterColumn("dbo.tblDosyalars", "davaVeyaTakipTuru", c => c.String(maxLength: 20));
            AlterColumn("dbo.tblDosyalars", "dosyaTuru", c => c.String(maxLength: 20));
        }
    }
}
