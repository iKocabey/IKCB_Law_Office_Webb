namespace DataAcceessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_tblMessage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblMessages", "SenderId", c => c.Int(nullable: false));
            AddColumn("dbo.tblMessages", "ReceiverId", c => c.Int(nullable: false));
            DropColumn("dbo.tblMessages", "SenderMessage");
            DropColumn("dbo.tblMessages", "ReceiverMessage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblMessages", "ReceiverMessage", c => c.String(maxLength: 50));
            AddColumn("dbo.tblMessages", "SenderMessage", c => c.String(maxLength: 50));
            DropColumn("dbo.tblMessages", "ReceiverId");
            DropColumn("dbo.tblMessages", "SenderId");
        }
    }
}
