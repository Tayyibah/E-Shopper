//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill_To
    {
        public int BillNo { get; set; }
        public string Display_Name { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string confirm_password { get; set; }
        public string Company_Name { get; set; }
        public string Email { get; set; }
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
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Total { get; set; }
    
        public virtual User User { get; set; }
    }
}
