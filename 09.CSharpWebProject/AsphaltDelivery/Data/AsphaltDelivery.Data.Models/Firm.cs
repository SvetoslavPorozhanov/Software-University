namespace AsphaltDelivery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.Firm;

    public class Firm
    {
        public Firm()
        {
            this.Trucks = new HashSet<Truck>();
            this.Drivers = new HashSet<Driver>();
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(FirmNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Truck> Trucks { get; set; }

        public ICollection<Driver> Drivers { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
