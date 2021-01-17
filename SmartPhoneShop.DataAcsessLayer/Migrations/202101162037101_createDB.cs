namespace SmartPhoneShop.DataAcsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SmartPhones",
                c => new
                    {
                        SmartPhoneId = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        ScreenSize = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SmartPhoneId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SmartPhones");
        }
    }
}
