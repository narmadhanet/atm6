namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cabtype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CabTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cabs", "CabTypeId", c => c.Int());
            CreateIndex("dbo.Cabs", "CabTypeId");
            AddForeignKey("dbo.Cabs", "CabTypeId", "dbo.CabTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cabs", "CabTypeId", "dbo.CabTypes");
            DropIndex("dbo.Cabs", new[] { "CabTypeId" });
            DropColumn("dbo.Cabs", "CabTypeId");
            DropTable("dbo.CabTypes");
        }
    }
}
