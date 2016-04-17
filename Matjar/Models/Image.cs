using System;
using System.Collections.Generic;
using System.Web;

namespace Matjar.Models
{
    public class Image
    {
        private string _imageName;

        public Image(HttpPostedFileBase file)
        {
            ImageName = Guid.NewGuid().ToString() + GetFileExtension(file);
        }

        

        public int ImageId { get; set; }
        public string ImageName
        {
            get { return _imageName; }
            set
            {
                string imageNameWithoutExtension = value.Split('.')[0];
                
                Guid newGuid;
                if (Guid.TryParse(value, out newGuid))
                {
                    _imageName = value;
                }
                else
                {
                    throw new FormatException("The image name is not a valid GUID format.");
                }
            }
        }
        public string ImageDescription { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


        private string GetFileExtension(HttpPostedFileBase file)
        {
            return System.IO.Path.GetExtension(file.FileName);
        }

        //private string GetFileExtension(string fileName)
        //{
        //    string fileExtension = null;
         
        //    if (fileName.Split('.').Length >= 2)
        //    {
        //        fileExtension = fileName.Split('.')[fileName.Split('.').Length - 1];
        //    }

        //    return fileExtension;
        //}
    }
}