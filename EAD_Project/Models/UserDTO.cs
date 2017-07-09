using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class UserDTO
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }

        public int UserID { get; set; }
        public String Name { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }

        public String PictureName { get; set; }
        public Boolean IsAdmin { get; set; }

        public Boolean IsActive { get; set; }

        public string Designation { get; set; }
        public string Email { get; set; }
    }
}