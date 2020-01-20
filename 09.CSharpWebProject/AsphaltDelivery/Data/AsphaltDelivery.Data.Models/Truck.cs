namespace AsphaltDelivery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.Truck;

    public class Truck
    {
        public Truck()
        {
            this.TruckDrivers = new HashSet<TruckDriver>();
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(TruckRegistrationNumberMaxLength)]
        public string RegistrationNumber { get; set; }

        public ICollection<TruckDriver> TruckDrivers { get; set; }

        [Required]
        public int FirmId { get; set; }

        public Firm Firm { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
