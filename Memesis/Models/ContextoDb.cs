using Memesis.Models.Negocios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Memesis.Models
{
    public class ContextoDb : DbContext
    {
        public ContextoDb()
            : base("DefaultConnection")
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<PerfilModel> Perfil{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}