namespace AsphaltDelivery.Data.Models
{
    public static class DataValidation
    {
        public static class Driver
        {
            public const int DriverFirstNameMaxLength = 30;
            public const int DriverLastNameMaxLength = 30;
        }

        public static class AsphaltBase
        {
            public const int AsphaltBaseNameMaxLength = 50;
        }

        public static class AsphaltMixture
        {
            public const int AsphaltMixtureTypeMaxLength = 30;
        }

        public static class Firm
        {
            public const int FirmNameMaxLength = 50;
        }

        public static class RoadObject
        {
            public const int RoadObjectNameMaxLength = 50;
        }

        public static class Truck
        {
            public const int TruckRegistrationNumberMaxLength = 8;
        }
    }
}
