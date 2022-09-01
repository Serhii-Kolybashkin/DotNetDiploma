using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings
{
    public class ProductAssemblyMapping : IEntityTypeConfiguration<ProductAssembly>
    {
        public void Configure(EntityTypeBuilder<ProductAssembly> builder)
        {
            builder.ToTable("ProductAssembly", "dbo");
            builder.HasKey(x => x.Id);
        }
    }
}
