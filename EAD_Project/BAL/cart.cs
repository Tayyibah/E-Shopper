using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class cart
    {
        public static int Save(EAD_Project.Models.cart dto)
        {
            return DAL.cart.Save(dto);
        }

        public static EAD_Project.Models.cart GetUserById(int pid)
        {
            return DAL.cart.GetUserById(pid);
        }
        public static List<EAD_Project.Models.cart> GetAllUser()
        {
            return DAL.cart.GetAllUser();
        }

        //public static int DeleteUser(int pid)
        //{
        //    return DAL.cart.DeleteUser(pid);
        //}
    }
}