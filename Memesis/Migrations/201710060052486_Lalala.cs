namespace Memesis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lalala : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PerfilModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataNasc = c.DateTime(nullable: false),
                        UsuarioModelId = c.Int(nullable: false),
                        Briografia = c.String(),
                        Avatar = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UsuarioModel", t => t.UsuarioModelId, cascadeDelete: true)
                .Index(t => t.UsuarioModelId);
            
            CreateTable(
                "dbo.UsuarioModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PerfilModel", "UsuarioModelId", "dbo.UsuarioModel");
            DropIndex("dbo.PerfilModel", new[] { "UsuarioModelId" });
            DropTable("dbo.UsuarioModel");
            DropTable("dbo.PerfilModel");
        }
    }
}
