using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matjar.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}