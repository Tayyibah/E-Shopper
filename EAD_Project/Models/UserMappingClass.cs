using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class UserMappingClass
    {
        public string name { get; set; }
        public List<MappingsModel> mapping { get; set; }
    }
}