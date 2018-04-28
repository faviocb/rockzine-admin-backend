using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace rockzine_admin_api.DAL
{
    public class RockzineDbContext : DbContext
    {

        public virtual DbSet<PeopleWhoLikeThisPage> PeopleWhoLikeThisPage { get; set; }
        public virtual DbSet<Sandbox> Sandbox { get; set; }
       
        public RockzineDbContext(DbContextOptions<RockzineDbContext> options)
            : base(options)
        { }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeopleWhoLikeThisPage>(entity =>
            {
                entity.ToTable("peoplewholikethispage");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.ResponseOffset).HasColumnName("responseoffset");
                entity.Property(e => e.ResponseText).HasColumnName("responsetext");
            });


            modelBuilder.Entity<Sandbox>(entity =>
            {
                entity.ToTable("sandbox");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
            });
        }

    }
}
