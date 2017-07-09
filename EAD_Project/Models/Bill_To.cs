using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    
    public class Bill_To
    {

        public int Total { get; set; }
        public int UserID { get; set; }
        public int BillNo { get; set; }
        public string Display_Name { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string confirm_password { get; set; }
        public string Company_Name { get; set; }
        public string Email { get; set; }
        public string Roll_Number { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile_Phone { get; set; }
        public string Fax { get; set; }
        public string message { get; set; }
        public string Shipping { get; set; }

    }
}