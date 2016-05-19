using System.Collections.Generic;

namespace Matjar.Models
{
    public class Product
    {
        public Product()
        {
            Images = new List<Image>();
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
        public bool ShowOnHomePage { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}