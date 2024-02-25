using BusarovsQuckBite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuckBite.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(e => e.Cart)
                .WithMany()
                .HasForeignKey(e => e.CartId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
