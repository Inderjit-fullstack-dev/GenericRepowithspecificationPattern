namespace GenericRepositoryWithSpecificationExample.Core.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}
