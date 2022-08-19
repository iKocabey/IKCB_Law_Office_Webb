namespace DataAcceessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_tblMessagess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblMessages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        SenderMessage = c.String(maxLength: 50),
                        ReceiverMessage = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 100),
                        MessageContent = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblMessages");
        }
    }
}
