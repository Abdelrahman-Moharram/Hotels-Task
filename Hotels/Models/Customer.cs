using System.ComponentModel.DataAnnotations;

namespace Hotels.Models
{
    public class Customer
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        
        [Required]
        public string Name { get; set; }

        [MaxLength(14), MinLength(14)]
        public string NationalId { get; set; }


        [MaxLength(11), MinLength(11)]
        public string PhoneNumber { get; set; }

    }
}
