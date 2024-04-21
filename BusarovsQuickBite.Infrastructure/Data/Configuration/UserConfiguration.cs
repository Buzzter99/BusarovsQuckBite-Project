using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuckBite.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = UserConstants.AdminId,
                    UserName = UserConstants.AdminUsername,
                    PasswordHash = hasher.HashPassword(null, "000000"),
                    Email = UserConstants.AdminEmail,
                    PhoneNumber = UserConstants.AdminPhoneNumber,
                    PhoneNumberConfirmed = true,
                    IsActive = true,
                    TransactionDateAndTime = DateTime.Now,
                    EmailConfirmed = true,
                    NormalizedEmail = UserConstants.AdminEmail.ToUpper(),
                    NormalizedUserName = UserConstants.AdminUsername.ToUpper()
                }
            );
        }
    }
}
