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

        public AddressService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AddressViewModel>> GetAddressesForUserAsync(string userId)
        {
            return await _context.Addresses.Where(x => x.User.Id == userId).Select(c => new AddressViewModel()
            {
                AddressId = c.Id,
                Street = c.Street,
                City = c.City,
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
                City = model.City,
                Street = model.Street,
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now,
                Who = userId
            };
            await _context.Addresses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
