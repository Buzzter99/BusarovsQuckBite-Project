using Microsoft.AspNetCore.Http;

namespace BusarovsQuickBite.Core.Contracts
{
    public interface IImgService
    {
        Task<int> AddImg(IFormFile file);
        Task DeleteUnusedImages();
    }
}
