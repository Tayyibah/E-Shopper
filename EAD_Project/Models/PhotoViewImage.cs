using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class PhotoViewImage
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public Byte[] ImageAlt { get; set; }
        public string ImageData { get; set; }
        public string ContentType { get; set; }
    }
}