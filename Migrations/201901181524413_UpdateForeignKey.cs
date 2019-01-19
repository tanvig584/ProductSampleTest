namespace ProductsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateForeignKey : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE ProductSubCategories ADD CONSTRAINT id FOREIGN KEY(categoryId) references ProductCategories(categoryId)");
        }
        
        public override void Down()
        {
        }
    }
}
