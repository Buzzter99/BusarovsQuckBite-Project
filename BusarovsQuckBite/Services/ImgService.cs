using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;

namespace BusarovsQuckBite.Services
{
    public class ImgService : IImgService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;

        public ImgService(IWebHostEnvironment hostingEnvironment, ApplicationDbContext context)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<int> AddImg(IFormFile file)
        {
            if (file.Length > 2 * 1024 * 1024)
            {
                throw new InvalidOperationException("File size should not exceed 2MB.");
            }
            string[] allowedExtensions = { ".png", ".jpg", ".jpeg" };
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            if (!allowedExtensions.Contains(fileExtension))
            {
                throw new InvalidOperationException("Only PNG, JPG, and JPEG files are allowed.");
            }
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
            string uniqueFileName = file.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            var entity = new Img()
            {
                Name = uniqueFileName,
                RelativePath = DataConstants.ImgConstants.ImgRelativePath + "/",
                FullPath = DataConstants.ImgConstants.ImgBasePath + $"/{uniqueFileName}"
            };
            await _context.Img.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

    }
}
