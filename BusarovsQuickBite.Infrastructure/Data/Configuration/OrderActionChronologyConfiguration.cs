using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuickBite.Infrastructure.Data.Configuration
{
    public class OrderActionChronologyConfiguration : IEntityTypeConfiguration<OrderActionChronology>
    {
        public void Configure(EntityTypeBuilder<OrderActionChronology> builder)
        {
            builder.HasOne(c => c.Order)
                .WithMany()
                .HasForeignKey(c => c.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
