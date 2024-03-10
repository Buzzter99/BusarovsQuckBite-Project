using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using Microsoft.EntityFrameworkCore;

namespace BusarovsQuckBite.Services
{
    public class AddressService : IAddressService
    {
        private readonly ApplicationDbContext _context;
        private readonly IDataProtectionService _protectionService;

        public AddressService(ApplicationDbContext context, IDataProtectionService protectionService)
        {
            _context = context;
            _protectionService = protectionService;
        }

        public async Task<List<AddressViewModel>> GetAddressesForUserAsync(string userId)
        {
            return await _context.Addresses.Where(x => x.User.Id == userId).Select(c => new AddressViewModel()
            {
                AddressId = c.Id,
                Street = _protectionService.Decrypt(c.Street),
                City = _protectionService.Decrypt(c.City),
                IsDeleted = c.IsDeleted
            }).ToListAsync();
        }
        private bool ContainsStreetNumber(string streetNumber)
        {
            return streetNumber.Any(char.IsDigit);
        }
        public async Task AddAddress(AddressViewModel model, string userId)
        {
            var streetValidation = ContainsStreetNumber(model.Street);
            if (!streetValidation)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.AddressShouldIncludeStreetNumber);
            }
            var entity = new Address()
            {
                City = _protectionService.Encrypt(model.City),
                Street = _protectionService.Encrypt(model.Street),
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = userId
            };
            await _context.Addresses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<Address> GetByIdForUser(int addressId, string userId)
        {
            var entity = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == addressId && x.Who == userId);
            if (entity == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            return entity;
        }
        public async Task DeleteAddress(int addressId, string userId)
        {
            var address = await GetByIdForUser(addressId,userId);
            address.IsDeleted = !address.IsDeleted;
            await _context.SaveChangesAsync();
        }
        private AddressViewModel MapViewModel(Address address)
        {
            return new AddressViewModel()
            {
                AddressId = address.Id,
                Street = address.Street,
                IsDeleted = address.IsDeleted,
                City = address.City
            };
        }
    }
}
