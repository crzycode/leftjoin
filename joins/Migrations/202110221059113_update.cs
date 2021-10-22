namespace joins.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModelInfoes",
                c => new
                    {
                        ModelId = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                    })
                .PrimaryKey(t => t.ModelId);
            
            CreateTable(
                "dbo.ProductDescriptions",
                c => new
                    {
                        ProductDesId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProdDetails = c.String(),
                    })
                .PrimaryKey(t => t.ProductDesId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProId = c.Int(nullable: false, identity: true),
                        ProName = c.String(),
                        ModelId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.ProductDescriptions");
            DropTable("dbo.ModelInfoes");
        }
    }
}
