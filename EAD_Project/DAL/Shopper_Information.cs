using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;


namespace EAD_Project.DAL
{
    public class Shopper_Information
    {

        public static int Save(EAD_Project.Models.Shopper_Information dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.Shopper_Information(Display_Name,User_Name,password,password2) VALUES('{0}','{1}','{2}','{3}')",
               dto.Display_Name, dto.User_Name, dto.password, dto.password2);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }


        public static EAD_Project.Models.Shopper_Information GetUserById(string User_Name)
        {

            var query = String.Format("Select * from dbo.Shopper_Information Where User_Name='{0}'", User_Name);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.Models.Shopper_Information dto = null;

                if (reader.Read())
                {
                    dto = FillDTO(reader);
                }

                return dto;
            }
        }
        public static List<EAD_Project.Models.Shopper_Information> GetAllUser()
        {
            using (DBHelper helper = new DBHelper())
            {
                var query = "Select * from dbo.Shopper_Information;";
                var reader = helper.ExecuteReader(query);
                List<EAD_Project.Models.Shopper_Information> list = new List<EAD_Project.Models.Shopper_Information>();

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

        public static int DeleteUser(string User_Name)
        {
            String sqlQuery = String.Format("Update dbo.Shopper_Information Set IsActive=0 Where User_Name='{0}'", User_Name);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        private static EAD_Project.Models.Shopper_Information FillDTO(SqlDataReader reader)
        {
            //Display_Name,User_Name,password,password2
            var dto = new EAD_Project.Models.Shopper_Information();
            dto.Display_Name = reader.GetString(0);
            dto.User_Name = reader.GetString(1);
            dto.password = reader.GetString(2);
            dto.password2 = reader.GetString(3);
            return dto;
        }
    }
}