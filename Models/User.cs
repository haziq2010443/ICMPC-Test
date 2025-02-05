namespace ICMPC_Test.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public int userId { get; set; }

        [Required]
        [MaxLength(100)]
        public string userName { get; set; }

        [Required]
        [MaxLength(255)]
        public string email { get; set; }

        [Required]
        public string passwordHash { get; set; } //Store hashed password for security

        //Navigate to products
        public ICollection<Product> Products { get; set; }
    }
}
