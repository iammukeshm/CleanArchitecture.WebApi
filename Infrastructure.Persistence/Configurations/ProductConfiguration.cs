using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(t => t.Barcode)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
