﻿using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface IAddressService
    {
        Task<List<AddressViewModel>> GetAddressesForUserAsync(string userId);
        Task AddAddress(AddressViewModel model, string userId);
        Task<Address> GetByIdForUser(int addressId, string userId);
        Task DeleteAddress(int addressId, string userId);
    }
}
