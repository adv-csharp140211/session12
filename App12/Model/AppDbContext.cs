using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace app07.Model
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=cs140211-codefirst3;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=AppDBFirst");
            optionsBuilder.LogTo(msg => Debug.WriteLine(msg));
            base.OnConfiguring(optionsBuilder);
        }


        public override int SaveChanges()
        {
            //
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent Api // Chaine API
            //modelBuilder.Entity<Category>().Property(x => x.Description)
            //        .HasMaxLength(200)
            //        .IsRequired()
            //        .IsUnicode(false)                    
            //        ;
            //modelBuilder.Entity<Category>().Property(x => x.Name)
            //        .HasMaxLength(100)
            //        .IsRequired()
            //        .IsUnicode(true)
            //        ;

            //modelBuilder.Entity<Product>().Property(x => x.Description)
            //        .HasMaxLength(200)
            //        .IsRequired()
            //        .IsUnicode(false)
            //        ;
            //modelBuilder.Entity<Product>().Property(x => x.Name)
            //        .HasMaxLength(100)
            //        .IsRequired()
            //        .IsUnicode(true)
            //        ;

            //modelBuilder.ApplyConfiguration(new CategoryConfig()); 
            //modelBuilder.ApplyConfiguration(new ProductConfig());

            //Reflection
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
