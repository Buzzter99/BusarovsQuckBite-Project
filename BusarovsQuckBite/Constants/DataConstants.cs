namespace BusarovsQuckBite.Constants
{
    public static class DataConstants
    {
        public static class AddressConstants
        {
            public const int StreetMinLength = 5;
            public const int StreetMaxLength = 250;
            public const int CityMinLength = 5;
            public const int CityMaxLength = 250;

        }

        public static class CartConstants
        {
            public const string CartTempDataKey = "CartItems";
        }

        public static class CategoryConstants
        {
            public const int CategoryMinLength = 5;
            public const int CategoryMaxLength = 250;
        }

        public static class OrderConstants
        {
            public const int TotalAmountPrecision = 18;
            public const int TotalAmountScale = 5;
        }

        public static class ProductConstants
        {
            public const int NameMinLength = 4;
            public const int NameMaxLength = 250;
            public const int DescriptionMinLength = 4;
            public const int DescriptionMaxLength = 200;
            public const int PricePrecision = 18;
            public const int PriceScale = 2;
        }
        public static class ImgConstants
        {
            public const int NameMaxLength = 100;
            public const int FullPathMaxLength = 150;
            public const int RelativePathMaxLength = 100;
            public const string ImgBasePath =
                "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images";
            public const string ImgRelativePath = "~/Images";
        }
    }
}
