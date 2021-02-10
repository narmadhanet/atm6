namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passengers", "AccountTypeId", c => c.Byte());
            CreateIndex("dbo.Passengers", "AccountTypeId");
            AddForeignKey("dbo.Passengers", "AccountTypeId", "dbo.AccountTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passengers", "AccountTypeId", "dbo.AccountTypes");
            DropIndex("dbo.Passengers", new[] { "AccountTypeId" });
            DropColumn("dbo.Passengers", "AccountTypeId");
        }
    }
}
