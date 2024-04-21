namespace BusarovsQuckBite.Constants
{
    public static class ErrorMessagesConstants
    {
        public const string EntityNotFoundExceptionMessage = "Entity does not exist!";
        public const string AddressShouldIncludeStreetNumber = "Street doesn't have Street Number!";
        public const string OwnerIsInvalid = "You are not the owner of this entity!";
        public const string FailedMessageKey = "Failed";
        public const string GeneralErrorMessage = "Invalid Operation!";
        public const string CannotDeleteProductInCategory = "You cannot delete this category because there are products inside! Please delete products first!";
    }
}
