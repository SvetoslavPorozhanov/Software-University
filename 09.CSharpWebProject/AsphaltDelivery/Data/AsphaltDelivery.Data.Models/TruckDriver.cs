namespace AsphaltDelivery.Data.Models
{
    public class TruckDriver
    {
        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public int TruckId { get; set; }

        public Truck Truck { get; set; }
    }
}
