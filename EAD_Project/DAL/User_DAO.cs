using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;
namespace EAD_Project.DAL
{
    public class User_DAO
    {
        public static int update(EAD_Project.PMS.Entities.UserDTO dto, string userGuid)//updates password where login
        {
            String sqlQuery = "";
            sqlQuery = String.Format("Update dbo.Users Set Password='{0}' WHERE Email='{1}')",
                dto.Password, dto.Email);
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        public static int updatePassword(string email, string Password)//Updates password and make CodeForReset=Null so that same link can't be used more 
        {
            String sqlQuery = "";
            sqlQuery = String.Format("Update dbo.Users Set Password='{0}' WHERE Email='{1}')",
                Password, email);
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        public static EAD_Project.PMS.Entities.UserDTO checkIsUser(String email)//is uder with this login exists 
        {
            var query = String.Format("Select * from dbo.Users Where Email={0}", email);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.PMS.Entities.UserDTO dto = null;
                if (reader.Read())
                {
                    dto = FillDTO1(reader);
                    return dto;
                }

                return dto;
            }
        }



        public static int Save(UsersTable dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.UsersTable(Login,Password,Designation,Email,isActive,UsersType,PictureName) VALUES('{0}','{1}','{2}','{3}','{4}',{5},'{6}')",
               dto.Login, dto.Password, dto.Designation, dto.Email, dto.isActive, dto.UsersType, dto.PictureName);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        public static int SaveUsers(PMS.Entities.UserDTO dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.Users(Name ,Login ,Password,IsAdmin,IsActive,PictureName ,Designation,Email) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                dto.Name ,dto.Login ,dto.Password, dto.IsAdmin,dto.IsActive,dto.PictureName ,dto.Designation,dto.Email);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        public static int Update(UsersTable dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("Update dbo.UsersTable Set Login='{0}',Password='{1}',Designation='{2}',Email='{3}',isActive='{4}',UsersType = {5} WHERE UserId='{6}')",
               dto.Login, dto.Password, dto.Designation, dto.Email, dto.isActive, dto.UsersType, dto.UserId);
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        public static UsersTable GetUserById(int pid)
        {

            var query = String.Format("Select * from dbo.UsersTable Where UserId={0}", pid);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                UsersTable dto = null;

                if (reader.Read())
                {
                    dto = FillDTO(reader);
                }

                return dto;
            }
        }
        public static List<UsersTable> GetAllUser()
        {
            using (DBHelper helper = new DBHelper())
            {
                var query = "Select * from dbo.UsersTable Where IsActive = 1;";
                var reader = helper.ExecuteReader(query);
                List<UsersTable> list = new List<UsersTable>();

                while (reader.Read())
                {
                    var dto = FillDTO(reader);
                    if (dto != null)
                    {
                        list.Add(dto);
                    }
                }

                return list;
            }
        }

        public static int DeleteUser(int pid)
        {
            String sqlQuery = String.Format("Update dbo.Users Set IsActive=0 Where UserID={0}", pid);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        private static UsersTable FillDTO(SqlDataReader reader)
        {
            var dto = new UsersTable();
            dto.UserId = reader.GetInt32(0);
            dto.Login = reader.GetString(1);
            dto.Password = reader.GetString(2);
            dto.Designation = reader.GetString(3);
            dto.Email = reader.GetString(4);
            // dto.isActive = Convert.ToBoolean(reader.GetByte(5));
            dto.isActive = reader.GetSqlBoolean(5).IsTrue;
            dto.UsersType = reader.GetInt32(6);
            return dto;
        }
        private static EAD_Project.PMS.Entities.UserDTO FillDTO1(SqlDataReader reader)
        {
            var dto = new EAD_Project.PMS.Entities.UserDTO();
            dto.UserID = reader.GetInt32(0);
            dto.Name = reader.GetString(1);
            dto.Login = reader.GetString(2);
            dto.Password = reader.GetString(3);
           // dto.IsAdmin = Convert.ToBoolean(reader.GetByte(4));
            dto.IsAdmin = reader.GetSqlBoolean(4).IsTrue;
            dto.IsActive = reader.GetSqlBoolean(5).IsTrue;
            dto.PictureName = reader.GetString(6);
            dto.Designation = reader.GetString(7);
            dto.Email = reader.GetString(8);
            return dto;
        }
        public static int UpdatePassword(UsersTable dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("Update dbo.Users Set Password='{0}' Where UserID={1}", dto.Password, dto.UserId);


            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        

        public static EAD_Project.PMS.Entities.UserDTO ValidateUser(String pLogin, String pPassword)
        {
          //  var query = String.Format("Select * from dbo.UsersTable Where Login='{0}' and Password='{1}'", pLogin, pPassword);
            var query = String.Format("Select * from dbo.Users Where Login='{0}' and Password='{1}'", pLogin, pPassword);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.PMS.Entities.UserDTO dto = null;

                if (reader.Read())
                {
                    dto = FillDTO1(reader);
                }

                return dto;
            }
        }
        public static EAD_Project.Models.UsersTable ValidateUser1(String pLogin, String pPassword)
        {
            var query = String.Format("Select * from dbo.UsersTable Where Login='{0}' and Password='{1}'", pLogin, pPassword);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.Models.UsersTable dto = null;

                if (reader.Read())
                {
                    dto = FillDTO(reader);
                }

                return dto;
            }
        }
    }
}
