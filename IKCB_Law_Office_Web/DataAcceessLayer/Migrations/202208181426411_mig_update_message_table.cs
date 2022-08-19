namespace DataAcceessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_message_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblPersonels", "TblMessage_MessageId", c => c.Int());
            CreateIndex("dbo.tblPersonels", "TblMessage_MessageId");
            AddForeignKey("dbo.tblPersonels", "TblMessage_MessageId", "dbo.tblMessages", "MessageId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblPersonels", "TblMessage_MessageId", "dbo.tblMessages");
            DropIndex("dbo.tblPersonels", new[] { "TblMessage_MessageId" });
            DropColumn("dbo.tblPersonels", "TblMessage_MessageId");
        }
    }
}
