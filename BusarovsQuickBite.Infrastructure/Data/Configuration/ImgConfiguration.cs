using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuickBite.Infrastructure.Data.Configuration
{
    public class ImgConfiguration : IEntityTypeConfiguration<Img>
    {
        public void Configure(EntityTypeBuilder<Img> builder)
        {
            builder.HasData(new List<Img>()
            {
                new Img()
                {
                    Id = 1,
                    Name = "download.jpg",
                    FullPath = $"{DataConstants.ImgConstants.ImgBasePath}/download.jpg",
                    RelativePath = $"{DataConstants.ImgConstants.ImgRelativePath}/"
                },
                new Img()
                {
                    Id = 2,
                    Name = "tuborg.jpg",
                    FullPath = $"{DataConstants.ImgConstants.ImgBasePath}/tuborg.jpg",
                    RelativePath = $"{DataConstants.ImgConstants.ImgRelativePath}/"
                },
                new Img()
                {
                    Id = 3,
                    Name = "hamburger-baked-in-oven.jpg",
                    FullPath = $"{DataConstants.ImgConstants.ImgBasePath}/hamburger-baked-in-oven.jpg",
                    RelativePath = $"{DataConstants.ImgConstants.ImgRelativePath}/"
                }

            });
        }
    }
}
