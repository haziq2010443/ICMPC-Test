namespace ICMPC_Test.Models
{
    public class PaginatedProductsViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
