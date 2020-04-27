namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comentarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Contenido = c.String(),
                        Autor = c.String(),
                        BlogPostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogPosts", t => t.BlogPostId, cascadeDelete: true)
                .Index(t => t.BlogPostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentarios", "BlogPostId", "dbo.BlogPosts");
            DropIndex("dbo.Comentarios", new[] { "BlogPostId" });
            DropTable("dbo.Comentarios");
        }
    }
}
