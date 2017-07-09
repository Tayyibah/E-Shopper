using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class contact_us
    {
        public static int Save(EAD_Project.Models.contact_us dto)
        {
            return DAL.contact_us.Save(dto);
        }
        public static EAD_Project.Models.contact_us GetUserById(string pid)
        {
            return DAL.contact_us.GetUserById(pid);
        }
        public static List<EAD_Project.Models.contact_us> GetAllUser()
        {
            return DAL.contact_us.GetAllUser();
        }

        //public static int DeleteUser(int pid)
        //{
        //    return DAL.contact_us.DeleteUser(pid);
        //}
    }
}