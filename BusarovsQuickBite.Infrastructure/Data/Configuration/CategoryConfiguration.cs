using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuickBite.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasOne(c => c.User)
                .WithMany(x => x.Categories)
                .HasForeignKey(c => c.Who)
                .OnDelete(DeleteBehavior.Restrict);
            List<Category> categories = new List<Category>();
            categories.Add(new Category()
            {
                Id = 1,
                Name = "Snacks",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = UserConstants.AdminId
            });
            categories.Add(new Category()
            {
                Id = 2,
                Name = "Burgers",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = UserConstants.AdminId
            });
            categories.Add(new Category()
            {
                Id = 3,
                Name = "Drinks",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = UserConstants.AdminId
            });
            categories.Add(new Category()
            {
                Id = 4,
                Name = "Pizzas",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = UserConstants.AdminId
            });
            categories.Add(new Category()
            {
                Id = 5,
                Name = "Pasta",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = UserConstants.AdminId
            });
            categories.Add(new Category()
            {
                Id = 6,
                Name = "Sandwiches",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = UserConstants.AdminId
            });
            categories.Add(new Category()
            {
                Id = 7,
                Name = "Desserts",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = UserConstants.AdminId
            });
            builder.HasData(categories);
        }
    }
}
