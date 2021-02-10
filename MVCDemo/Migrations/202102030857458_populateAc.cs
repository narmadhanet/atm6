namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateAc : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AccountTypes(Id,PrePaidAmount,DurationInMonths,OfferRate) VALUES(1,0,0,0)");
            Sql("INSERT INTO AccountTypes(Id,PrePaidAmount,DurationInMonths,OfferRate) VALUES(2,30,1,10)");
            Sql("INSERT INTO AccountTypes(Id,PrePaidAmount,DurationInMonths,OfferRate) VALUES(3,90,3,15)");
            Sql("INSERT INTO AccountTypes(Id,PrePaidAmount,DurationInMonths,OfferRate) VALUES(4,150,12,20)");

        }

        public override void Down()
        {
        }
    }
}
