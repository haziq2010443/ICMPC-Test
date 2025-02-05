namespace ICMPC_Test.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public int productId { get; set; }

        [Required]
        [MaxLength(255)]
        public string productName { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        //foreign key
        public int userId { get; set; }

        [ForeignKey("userId")]
        public User user { get; set; }
    }
}
