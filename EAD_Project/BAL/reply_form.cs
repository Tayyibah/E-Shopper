using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class reply_form
    {
        public static int Save(EAD_Project.Models.reply_form dto)
        {
            return DAL.reply_form.Save(dto);
        }

        //public static EAD_Project.Models.reply_form GetUserById(string pid)
        //{
        //    return DAL.reply_form.GetUserById(pid);
        //}
        public static List<EAD_Project.Models.reply_form> GetAllUser()
        {
            return DAL.reply_form.GetAllUser();
        }

        //public static int DeleteUser(string pid)
        //{
        //    return DAL.reply_form.DeleteUser(pid);
        //}
    }
}