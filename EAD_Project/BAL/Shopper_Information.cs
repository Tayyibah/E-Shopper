using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class Shopper_Information
    {
        public static int Save(EAD_Project.Models.Shopper_Information dto)
        {
            return DAL.Shopper_Information.Save(dto);
        }
        public static EAD_Project.Models.Shopper_Information GetUserById(string pid)
        {
            return DAL.Shopper_Information.GetUserById(pid);
        }
        public static List<EAD_Project.Models.Shopper_Information> GetAllUser()
        {
            return DAL.Shopper_Information.GetAllUser();
        }

        public static int DeleteUser(string pid)
        {
            return DAL.Shopper_Information.DeleteUser(pid);
        }
    }
}