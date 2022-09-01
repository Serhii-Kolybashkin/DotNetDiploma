using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappings
{
    public class PartComponentMapping : IEntityTypeConfiguration<PartComponent>
    {
        public void Configure(EntityTypeBuilder<PartComponent> builder)
        {
            builder.ToTable("PartComponent", "dbo");
            builder.HasKey(x => x.Id);
        }
    }
}
