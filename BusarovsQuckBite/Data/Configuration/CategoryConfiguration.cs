using BusarovsQuckBite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuckBite.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasOne(c => c.User)
                .WithMany(x => x.Categories)
                .HasForeignKey(c => c.Who)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
