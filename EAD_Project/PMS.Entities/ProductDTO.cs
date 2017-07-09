using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.PMS.Entities
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public String Name { get; set; }

        public int Price { get; set; }
        public String PictureName { get; set; }
        public DateTime CreatedOn { get; set; }
        public String CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public String ModifiedBy { get; set; }
        public Boolean IsActive { get; set; }

        public List<CommentDTO> Comments
        {
            get;
            set;
        }
    }
}
