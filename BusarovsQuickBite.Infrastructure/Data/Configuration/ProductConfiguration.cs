using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuickBite.Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(c => c.User)
                .WithMany(x => x.Products)
                .HasForeignKey(c => c.Who)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Pepperoni Pizza",
                    Description = "Pizza",
                    ImageId = 1,
                    CategoryId = 4,
                    Price = 15.00m,
                    Quantity = 10,
                    Who = UserConstants.AdminId,
                    IsDeleted = false,
                    TransactionDateAndTime = DateTime.Now
                },
                new Product()
                {
                    Id = 2,
                    Name = "Tuborg Beer",
                    Description = "Beer",
                    ImageId = 2,
                    CategoryId = 3,
                    Price = 5.00m,
                    Quantity = 50,
                    Who = UserConstants.AdminId,
                    IsDeleted = false,
                    TransactionDateAndTime = DateTime.Now
                },
                new Product()
                {
                    Id = 3,
                    Name = "Hamburger",
                    Description = "Burger",
                    ImageId = 3,
                    CategoryId = 2,
                    Price = 8.50m,
                    Quantity = 15,
                    Who = UserConstants.AdminId,
                    IsDeleted = false,
                    TransactionDateAndTime = DateTime.Now
                }
            });
        }
    }
}
