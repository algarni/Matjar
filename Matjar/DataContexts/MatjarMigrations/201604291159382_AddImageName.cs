namespace Matjar.DataContexts.MatjarMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "ImageName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "ImageName");
        }
    }
}
