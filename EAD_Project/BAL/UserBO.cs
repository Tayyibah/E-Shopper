using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class UserBO
    {

        public static int update(EAD_Project.PMS.Entities.UserDTO dto, string userGuid)
        {
            return DAL.User_DAO.update(dto, userGuid);
        }
        public static int SaveUsers(PMS.Entities.UserDTO dto)
        {
            return DAL.User_DAO.SaveUsers(dto);
        }
        public static int Save(EAD_Project.Models.UsersTable dto)
        {
            return DAL.User_DAO.Save(dto);
        }
        public static EAD_Project.PMS.Entities.UserDTO checkIsUser(String email)
        {
            return DAL.User_DAO.checkIsUser(email);
        }
        public static int updatePassword(string email, string code)
        {
            return DAL.User_DAO.updatePassword(email, code);
        }
        public static int UpdatePassword(EAD_Project.Models.UsersTable dto)
        {
            return DAL.User_DAO.UpdatePassword(dto);
        }
        public static EAD_Project.Models.UsersTable ValidateUser1(String pLogin, String pPassword)
        {
            return DAL.User_DAO.ValidateUser1(pLogin, pPassword);
        }
        public static EAD_Project.PMS.Entities.UserDTO ValidateUser(String pLogin, String pPassword)
        {
            return DAL.User_DAO.ValidateUser(pLogin, pPassword);
        }
        public static EAD_Project.Models.UsersTable GetUserById(int pid)
        {
            return DAL.User_DAO.GetUserById(pid);
        }
        public static List<EAD_Project.Models.UsersTable> GetAllUser()
        {
            return DAL.User_DAO.GetAllUser();
        }

        public static int DeleteUser(int pid)
        {
            return DAL.User_DAO.DeleteUser(pid);
        }

    }
}
