using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuickBite.Infrastructure.DataConstants;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

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
                throw new ApplicationException("File size should not exceed 2MB.");
            }
            string[] allowedExtensions = { ".png", ".jpg", ".jpeg" };
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            if (!allowedExtensions.Contains(fileExtension))
            {
                throw new ApplicationException("Only PNG, JPG, and JPEG files are allowed.");
            }
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
            string uniqueFileName = file.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            if (File.Exists(filePath))
            {
                var exists = await _context.Img.FirstOrDefaultAsync(x => x.Name == uniqueFileName);
                if (exists != null)
                {
                    return exists.Id;
                }
                throw new ApplicationException(ErrorMessagesConstants.GeneralErrorMessage);
            }
            string relativePath = DataConstants.ImgConstants.ImgRelativePath + "/";
            string fullPath = DataConstants.ImgConstants.ImgBasePath + $"/{uniqueFileName}";
            if (fullPath.Length > DataConstants.ImgConstants.FullPathMaxLength)
            {
                throw new ApplicationException("Path exceeds max limit!");
            }
            var entity = new Img()
            {
                Name = uniqueFileName,
                RelativePath = relativePath,
                FullPath = fullPath
            };
            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            await _context.Img.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
        public async Task DeleteUnusedImages()
        {
            var unusedImages = _context.Img.Where(x => !x.Products.Any()).ToList();
            foreach (var img in unusedImages)
            {
                File.Delete(img.FullPath);
                _context.Img.Remove(img);
            }
            await _context.SaveChangesAsync();
        }
    }
}
