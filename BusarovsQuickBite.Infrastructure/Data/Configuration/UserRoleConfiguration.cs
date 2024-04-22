using BusarovsQuickBite.Infrastructure.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusarovsQuickBite.Infrastructure.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = UserConstants.AdminId
                }
            );
        }
    }
}
