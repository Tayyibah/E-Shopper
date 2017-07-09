using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class SellDTO
    {
        //public List<ProductDTO> Products { get; set; }
        //public List<UserDTO> Users { get; set; }
        public ProductDTO Products { get; set; }
        public UserDTO Users { get; set; }
    }
}