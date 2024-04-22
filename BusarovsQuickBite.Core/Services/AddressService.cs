using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Models.Address;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Common;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Core.Services
{
    public class AddressService : IAddressService
    {
        private readonly IRepository _repository;
        private readonly IDataProtectionService _protectionService;

        public AddressService(IRepository repository, IDataProtectionService protectionService)
        {
            _repository = repository;
            _protectionService = protectionService;
        }

        public async Task<List<AddressViewModel>> GetAddressesForUserAsync(string userId)
        {
            return await _repository.AllReadOnly<Address>().Where(x => x.User.Id == userId).Select(c => new AddressViewModel()
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
                throw new ApplicationException(ErrorMessagesConstants.AddressShouldIncludeStreetNumber);
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
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
        }
        public async Task<AddressViewModel> GetByIdForUser(int addressId, string userId)
        {
            var entity = await _repository.GetByIdAsync<Address>(addressId);
            if (entity == null)
            {
                throw new ApplicationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            if (entity.Who != userId)
            {
                throw new ApplicationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            return MapViewModel(entity);
        }
        public async Task DeleteAddress(int addressId, string userId)
        {
            var address = await _repository.GetByIdAsync<Address>(addressId);
            if (address == null)
            {
                throw new ApplicationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            if (address.Who != userId)
            {
                throw new ApplicationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            address.IsDeleted = !address.IsDeleted;
            await _repository.SaveChangesAsync();
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
            var address = await _repository.GetByIdAsync<Address>(model.AddressId);
            if (address == null)
            {
                throw new ApplicationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            if (address.Who != userId)
            {
                throw new ApplicationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            address.City = _protectionService.Encrypt(model.City);
            address.Street = _protectionService.Encrypt(model.Street);
            await _repository.SaveChangesAsync();
        }

        public async Task<List<AddressViewModel>> GetActiveAddressesForUser(string userId)
        {
            return await _repository.AllReadOnly<Address>().Where(x => x.User.Id == userId && !x.IsDeleted).Select(c => new AddressViewModel()
            {
                AddressId = c.Id,
                Street = _protectionService.Decrypt(c.Street),
                City = _protectionService.Decrypt(c.City),
            }).ToListAsync();
        }
    }
}
