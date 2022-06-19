using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Gestion_Restaurant
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<commandes> commandes { get; set; }
        public virtual DbSet<manager> manager { get; set; }
        public virtual DbSet<plats> plats { get; set; }
        public virtual DbSet<serveurs> serveurs { get; set; }
        public virtual DbSet<tables> tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            modelBuilder.Entity<commandes>()
                .HasMany(e => e.plats)
                .WithMany(e => e.commandes)
                .Map(m => m.ToTable("contient").MapLeftKey("id_commande").MapRightKey("id_plat"));

            modelBuilder.Entity<serveurs>()
                .HasMany(e => e.tables)
                .WithMany(e => e.serveurs)
                .Map(m => m.ToTable("affecter").MapLeftKey("id_serveur").MapRightKey("id_table"));

            modelBuilder.Entity<tables>()
                .HasMany(e => e.commandes)
                .WithOptional(e => e.tables)
                .HasForeignKey(e => e.tableid);
        }
    }
}
