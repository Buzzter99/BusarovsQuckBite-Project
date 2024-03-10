using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface IAddressService
    {
        Task<List<AddressViewModel>> GetAddressesForUserAsync(string userId);
        Task AddAddress(AddressViewModel model, string userId);
    }
}
