namespace AsphaltDelivery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.Driver;

    public class Driver
    {
        public Driver()
        {
            this.DriverTrucks = new HashSet<TruckDriver>();
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(DriverFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(DriverLastNameMaxLength)]
        public string LastName { get; set; }

        public ICollection<TruckDriver> DriverTrucks { get; set; }

        [Required]
        public int FirmId { get; set; }

        public Firm Firm { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
