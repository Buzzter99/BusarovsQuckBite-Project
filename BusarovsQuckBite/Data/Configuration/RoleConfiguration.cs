using BusarovsQuckBite.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using BusarovsQuckBite.Constants;

namespace BusarovsQuckBite.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(new ApplicationRole() 
            { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", 
                Name = RoleConstants.AdminRoleName
                ,NormalizedName = RoleConstants.AdminRoleName.ToUpper(),
                TransactionDateAndTime = DateTime.Now
            },new ApplicationRole()
            {
                Id = "fa175b24-e5a7-41ab-8237-94734f2b5408",
                Name = RoleConstants.CustomerRoleName,
                NormalizedName = RoleConstants.CustomerRoleName.ToUpper(),
                TransactionDateAndTime = DateTime.Now
            }, new ApplicationRole()
            {
                Id = "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                Name = RoleConstants.DeliveryDriverRoleName,
                NormalizedName = RoleConstants.DeliveryDriverRoleName.ToUpper(),
                TransactionDateAndTime = DateTime.Now
            }, new ApplicationRole()
            {
                Id = "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                Name = RoleConstants.CookingStaffRoleName,
                NormalizedName = RoleConstants.CookingStaffRoleName.ToUpper(),
                TransactionDateAndTime = DateTime.Now
            });
        }
    }
}
