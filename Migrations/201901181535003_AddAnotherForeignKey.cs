namespace ProductsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnotherForeignKey : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Products ADD CONSTRAINT subId FOREIGN KEY(subCategoryId) references ProductSubCategories(subCategoryId)");
        }
        
        public override void Down()
        {
        }
    }
}
