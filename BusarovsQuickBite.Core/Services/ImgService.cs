using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Common;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Core.Services
{
    public class ImgService : IImgService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IRepository _repository;

        public ImgService(IWebHostEnvironment hostingEnvironment, IRepository repository)
        {
            _repository = repository;
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
                var exists = await _repository.GetEntity<Img>().FirstOrDefaultAsync(x => x.Name == uniqueFileName);
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
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return entity.Id;
        }
        public async Task DeleteUnusedImages()
        {
            var unusedImages = _repository.GetEntity<Img>().Where(x => !x.Products.Any()).ToList();
            foreach (var img in unusedImages)
            {
                File.Delete(img.FullPath);
                _repository.DeleteEntity(img);
            }
            await _repository.SaveChangesAsync();
        }
    }
}
