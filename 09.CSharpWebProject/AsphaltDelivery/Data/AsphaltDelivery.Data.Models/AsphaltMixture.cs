namespace AsphaltDelivery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.AsphaltMixture;

    public class AsphaltMixture
    {
        public AsphaltMixture()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(AsphaltMixtureTypeMaxLength)]
        public string Type { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
