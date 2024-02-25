using BusarovsQuckBite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuckBite.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(c => c.User)
                .WithMany(x => x.Products)
                .HasForeignKey(c => c.Who)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
