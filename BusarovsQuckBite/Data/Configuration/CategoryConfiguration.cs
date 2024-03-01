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
            List<Category> categories = new List<Category>();
            categories.Add(new Category()
            {
                Id = 1,
                Name = "Snacks",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
            categories.Add(new Category()
            {
                Id = 2,
                Name = "Burgers",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
            categories.Add(new Category()
            {
                Id = 3,
                Name = "Drinks",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
            categories.Add(new Category()
            {
                Id = 4,
                Name = "Pizzas",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
            categories.Add(new Category()
            {
                Id = 5,
                Name = "Pasta",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
            categories.Add(new Category()
            {
                Id = 6,
                Name = "Sandwiches",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
            categories.Add(new Category()
            {
                Id = 7,
                Name = "Desserts",
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
            builder.HasData(categories);
        }
    }
}
