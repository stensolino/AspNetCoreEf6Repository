namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatetypeforPermissionNameproperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Permissions", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Permissions", "Name", c => c.Int(nullable: false));
        }
    }
}
