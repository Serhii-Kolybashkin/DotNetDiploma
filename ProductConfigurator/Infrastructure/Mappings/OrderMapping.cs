using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", "dbo");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.PartComponents).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);
        }
    }
}
