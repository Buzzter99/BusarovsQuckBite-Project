using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuickBite.Infrastructure.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(c => c.Address)
                .WithMany()
                .HasForeignKey(c => c.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
