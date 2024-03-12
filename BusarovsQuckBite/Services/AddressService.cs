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
            if (!streetNumber.Any(char.IsDigit))
            {
                throw new InvalidOperationException(ErrorMessagesConstants.AddressShouldIncludeStreetNumber);
            }
            return true;
        }
        public async Task AddAddress(AddressViewModel model, string userId)
        {
            ContainsStreetNumber(model.Street);
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
        public async Task<AddressViewModel> GetByIdForUser(int addressId, string userId)
        {
            var entity = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == addressId);
            if (entity == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            if (entity.Who != userId)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            return MapViewModel(entity);
        }
        public async Task DeleteAddress(int addressId, string userId)
        {
            var address = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == addressId);
            if (address == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            if (address.Who != userId)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            address.IsDeleted = !address.IsDeleted;
            await _context.SaveChangesAsync();
        }
        private AddressViewModel MapViewModel(Address address)
        {
            return new AddressViewModel()
            {
                AddressId = address.Id,
                Street = _protectionService.Decrypt(address.Street),
                IsDeleted = address.IsDeleted,
                City = _protectionService.Decrypt(address.City)
            };
        }

        public async Task EditAddress(AddressViewModel model, string userId)
        {
            ContainsStreetNumber(model.Street);
            var address = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == model.AddressId);
            if (address == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            if (address.Who != userId)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            address.City = _protectionService.Encrypt(model.City);
            address.Street = _protectionService.Encrypt(model.Street);
            await _context.SaveChangesAsync();
        }

    }
}
