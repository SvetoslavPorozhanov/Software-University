namespace AsphaltDelivery.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        [Required]
        public int TruckId { get; set; }

        public Truck Truck { get; set; }

        [Required]
        public int FirmId { get; set; }

        public Firm Firm { get; set; }

        [Required]
        public int AsphaltBaseId { get; set; }

        public AsphaltBase AsphaltBase { get; set; }

        [Required]
        public int AsphaltMixtureId { get; set; }

        public AsphaltMixture AsphaltMixture { get; set; }

        [Required]
        public int RoadObjectId { get; set; }

        public RoadObject RoadObject { get; set; }

        //In t
        [Required]
        public double Weight { get; set; }

        //In km
        [Required]
        public double TransportDistance { get; set; }

        //In tkm
        public double WeightByDistance => this.Weight * this.TransportDistance;
    }
}
