using System.ComponentModel.DataAnnotations;

namespace Proj_Learn_ASP_Net_Core_MVC_7.Models.Domain
{
    public class PersonModel
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
