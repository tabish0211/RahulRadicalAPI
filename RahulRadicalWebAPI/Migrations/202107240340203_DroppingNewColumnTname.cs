namespace RahulRadicalWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DroppingNewColumnTname : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "TName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "TName", c => c.String());
        }
    }
}
