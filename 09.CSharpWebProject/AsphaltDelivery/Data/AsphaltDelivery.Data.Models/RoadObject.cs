namespace AsphaltDelivery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.RoadObject;

    public class RoadObject
    {
        public RoadObject()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(RoadObjectNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
