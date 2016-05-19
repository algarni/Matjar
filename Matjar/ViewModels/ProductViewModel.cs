using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Matjar.ViewModels
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}