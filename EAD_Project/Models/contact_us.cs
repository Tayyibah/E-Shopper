using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class contact_us
    {
        public string name { get; set; }
        public string email { get; set; }
        
        public string subject { get; set; }
        public string message { get; set; }
        public int Contact_Id { get; set; }
    }
}