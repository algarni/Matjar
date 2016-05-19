using System;
using System.Collections.Generic;
using System.Web;

namespace Matjar.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageTitle { get; set; }
        public string ImageDescription { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string ImageName { get; set; }
    }
}