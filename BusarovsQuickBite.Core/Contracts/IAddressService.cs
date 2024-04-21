using BusarovsQuckBite.Models.Address;

namespace BusarovsQuckBite.Contracts
{
    public interface IAddressService
    {
        Task<List<AddressViewModel>> GetAddressesForUserAsync(string userId);
        Task AddAddress(AddressViewModel model, string userId);
        Task<AddressViewModel> GetByIdForUser(int addressId, string userId);
        Task DeleteAddress(int addressId, string userId);
        Task EditAddress(AddressViewModel model, string userId);
        Task<List<AddressViewModel>> GetActiveAddressesForUser(string userId);
    }
}
