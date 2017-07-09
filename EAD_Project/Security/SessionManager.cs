using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Security
{
    public class SessionManager
    {
        public static EAD_Project.Models.UsersTable User1
        {
            get
            {
                EAD_Project.Models.UsersTable dto = null;
                if (HttpContext.Current.Session["User1"] != null)
                {
                    dto = HttpContext.Current.Session["User1"] as EAD_Project.Models.UsersTable;
                }

                return dto;
            }
            set
            {
                HttpContext.Current.Session["User1"] = value;
            }
        }
        public static EAD_Project.PMS.Entities.UserDTO User
        {
            get
            {
                EAD_Project.PMS.Entities.UserDTO dto = null;
                if (HttpContext.Current.Session["User"] != null)
                {
                    dto = HttpContext.Current.Session["User"] as EAD_Project.PMS.Entities.UserDTO;
                }

                return dto;
            }
            set
            {
                HttpContext.Current.Session["User"] = value;
            }
        }
        public static EAD_Project.PMS.Entities.ProductDTO Product
        {
            get
            {
                EAD_Project.PMS.Entities.ProductDTO dto = null;
                if (HttpContext.Current.Session["Product"] != null)
                {
                    dto = HttpContext.Current.Session["Product"] as EAD_Project.PMS.Entities.ProductDTO;
                }

                return dto;
            }
            set
            {
                HttpContext.Current.Session["User"] = value;
            }
        }
        //public static int total
        //{
        //    get
        //    {
        //        int dto = 0;
        //        if (HttpContext.Current.Session["total"] != null)
        //        {
        //            dto = HttpContext.Current.Session["total"] as int;
        //        }

        //        return HttpContext.Current.Session["total"];
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session["total"] = value;
        //    }
        //}
        public static Boolean IsValidUser
        {
            get
            {
                if (User != null)
                    return true;
                else
                {

                }
                return false;
            }
        }

        public static void ClearSession()
        {
            HttpContext.Current.Session.RemoveAll();
            HttpContext.Current.Session.Abandon();
        }
    }
}