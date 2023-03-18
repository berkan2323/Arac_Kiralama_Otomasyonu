namespace rent_a_car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musterilers", "EhliyetNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musterilers", "EhliyetNo", c => c.Int(nullable: false));
        }
    }
}
