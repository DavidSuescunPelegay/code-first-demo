namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePost : DbMigration
    {
        public override void Up()//Metodo para upgradear la BBDD
        {
            CreateTable(
                    "dbo.Posts",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatePublished = c.DateTime(nullable: false),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            //Automaticamente añade como primaryKey la columna id

        }
        
        public override void Down()//Metodo para downgradear la BBDD
        {
            DropTable("dbo.Posts");
        }
    }
}
