namespace BusarovsQuckBite.Contracts
{
    public interface IImgService
    {
        Task<int> AddImg(IFormFile file);
        Task DeleteUnusedImages();
    }
}
