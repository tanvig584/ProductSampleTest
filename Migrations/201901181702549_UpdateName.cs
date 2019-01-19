namespace ProductsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "productName", c => c.String());
            AddColumn("dbo.ProductCategories", "categoryName", c => c.String());
            AddColumn("dbo.ProductSubCategories", "subCategoryName", c => c.String());
            DropColumn("dbo.Products", "name");
            DropColumn("dbo.ProductCategories", "name");
            DropColumn("dbo.ProductSubCategories", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductSubCategories", "name", c => c.String());
            AddColumn("dbo.ProductCategories", "name", c => c.String());
            AddColumn("dbo.Products", "name", c => c.String());
            DropColumn("dbo.ProductSubCategories", "subCategoryName");
            DropColumn("dbo.ProductCategories", "categoryName");
            DropColumn("dbo.Products", "productName");
        }
    }
}
