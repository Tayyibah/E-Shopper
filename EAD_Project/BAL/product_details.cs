using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class product_details
    {
        public static int Save(EAD_Project.Models.product_details dto)
        {
            return DAL.product_details.Save(dto);
        }
        public static EAD_Project.Models.product_details GetUserById(string pid)
        {
            return DAL.product_details.GetUserById(pid);
        }
        public static List<EAD_Project.Models.product_details> GetAllUser()
        {
            return DAL.product_details.GetAllUser();
        }

        public static int DeleteUser(string pid)
        {
            return DAL.product_details.DeleteUser(pid);
        }
    }
}