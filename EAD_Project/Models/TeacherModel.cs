using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class TeacherModel
    {
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string tEACHERsUBJECT { get; set; }
    }
}