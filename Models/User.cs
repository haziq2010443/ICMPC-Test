using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ICMPC_Test.Models
{

    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; } //Store hashed password for security

        //Navigate to products
        public ICollection<Product>? Products { get; set; }
    }
}
