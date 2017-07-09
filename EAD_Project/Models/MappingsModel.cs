using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class MappingsModel
    {
        public int MappingId { get; set; }
        public int UserId { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<bool> AddToCart { get; set; }
        public Nullable<System.DateTime> Date { get; set; }


        public int MappingID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> TeacherID { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        
    }
}