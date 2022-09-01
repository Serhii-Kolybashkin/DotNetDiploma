using BusinessLogic.Entities;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContexts
{
    public class DataContext : DbContext
    {
        public DbSet<PartComponent> components { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<ProductAssembly> productAssembledes { get; set; }
        //public DbSet<PartProductJoin> PartProductJoin { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(nameof(DataContext));
            //optionsBuilder.UseSqlServer("Server = .; Database = DiplomaDataBase; Trusted_Connection = True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PartComponentMapping());
            //modelBuilder.ApplyConfiguration(new ProductAssemblyMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            //modelBuilder.ApplyConfiguration(new ProductWithParts());
            //modelBuilder.Entity<PartProductJoin>().HasKey(x => new { x.PartComponentId, x.ProductAssemblyId });

            //modelBuilder.Entity<PartProductJoin>()
            //    .HasOne<PartComponent>(x => x.PartComponent)
            //    .WithMany(x => x.ProductAssemblies)
            //    .HasForeignKey(x => x.PartComponentId);

            //modelBuilder.Entity<PartProductJoin>()
            //    .HasOne<ProductAssembly>(x => x.ProductAssembly)
            //    .WithMany(x => x.PartComponents)
            //    .HasForeignKey(x => x.ProductAssemblyId);

            //modelBuilder.Entity<ProductAssembly>()
            //    .HasMany(x => x.PartComponents)
            //    .WithMany(x => x.ProductAssembly)
            //    .UsingEntity<PartProductJoin>(
            //    x => x.HasOne(x => x.PartComponent).WithMany().HasForeignKey(x => x.PartComponentId),
            //    x => x.HasOne(x => x.ProductAssembly).WithMany().HasForeignKey(x => x.ProductAssemblyId));


            modelBuilder.Entity<PartComponent>()
                .HasMany(x => x.ProductAssemblies)
                .WithMany(x => x.PartComponents)
                .UsingEntity(x => x.ToTable("ProductAndPart"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
