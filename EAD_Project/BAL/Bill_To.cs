using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class Bill_To
    {
        public static int Save(EAD_Project.Models.Bill_To dto)
        {
            return DAL.Bill_To.Save(dto);
        }
        //public static EAD_Project.Models.Bill_To GetUserById(int pid)
        //{
        //    return DAL.Bill_To.GetUserById(pid);
        //}
        //public static List<EAD_Project.Models.Bill_To> GetAllUser()
        //{
        //    return DAL.Bill_To.GetAllUser();
        //}

        //public static int DeleteUser(int pid)
        //{
        //    return DAL.Bill_To.DeleteUser(pid);
        //}
    }
}