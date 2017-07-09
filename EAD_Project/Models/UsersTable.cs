using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class UsersTable
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public Boolean isActive { get; set; }
        public int UsersType { get; set; }
        public String PictureName { get; set; }
    }
}