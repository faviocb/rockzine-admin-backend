// using System;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata;


// namespace rockzine_admin_api.DAL
// {
//     public class RockzinedbContext : DbContext
//     {

      

//         public virtual DbSet<PeopleWhoLikeThisPage> PeopleWhoLikeThisPage { get; set; }
//         public virtual DbSet<Sandbox> Sandbox { get; set; }
       
//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             modelBuilder.Entity<PeopleWhoLikeThisPage>(entity =>
//             {
//                 entity.ToTable("PeopleWhoLikeThisPage");

//                 entity.Property(e => e.ResponseId).HasColumnName("ResponseId");
//                 entity.Property(e => e.ResponseOffset).HasColumnName("ResponseOffset");
//                 entity.Property(e => e.ResponseText).HasColumnName("ResponseText");
//             });


//             modelBuilder.Entity<Sandbox>(entity =>
//             {
//                 entity.ToTable("sandbox");

//                 entity.Property(e => e.Id).HasColumnName("id");

//                 entity.Property(e => e.Name).HasColumnName("name");
//             });
//         }

//     }
// }
