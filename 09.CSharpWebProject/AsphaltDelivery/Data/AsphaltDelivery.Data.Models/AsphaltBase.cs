namespace AsphaltDelivery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.AsphaltBase;

    public class AsphaltBase
    {
        public AsphaltBase()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(AsphaltBaseNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
