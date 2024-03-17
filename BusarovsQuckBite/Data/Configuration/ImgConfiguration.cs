using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuckBite.Data.Configuration
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
                    Name = "global_tuborg-green.png",
                    FullPath = $"{DataConstants.ImgConstants.ImgBasePath}/global_tuborg-green.png",
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
