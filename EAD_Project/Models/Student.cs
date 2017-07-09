using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class Student
    {
        public string name { get; set; }
        public List<MappingsModel> mapping { get; set; }
      //  public IEnumerable<MappingsModel> mapping { get; set; }
    }
}