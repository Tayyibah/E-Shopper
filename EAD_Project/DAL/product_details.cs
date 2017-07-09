using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;

namespace EAD_Project.DAL
{
    public class product_details
    {
        public static int Save(EAD_Project.Models.product_details dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.product_details(name,email,textarea_text) VALUES('{0}','{1}','{2}')",
               dto.name, dto.email, dto.textarea_text);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        public static int Update(EAD_Project.Models.product_details dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("Update dbo.product_details Set email='{0}',textarea_text='{1}' WHERE name='{2}')",
                dto.email, dto.textarea_text, dto.name);
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        public static EAD_Project.Models.product_details GetUserById(string pid)
        {

            var query = String.Format("Select * from dbo.product_details Where name='{0}'", pid);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.Models.product_details dto = null;

                if (reader.Read())
                {
                    dto = FillDTO(reader);
                }

                return dto;
            }
        }
        public static List<EAD_Project.Models.product_details> GetAllUser()
        {
            using (DBHelper helper = new DBHelper())
            {
                var query = "Select * from dbo.product_details";
                var reader = helper.ExecuteReader(query);
                List<EAD_Project.Models.product_details> list = new List<EAD_Project.Models.product_details>();

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

        public static int DeleteUser(string pid)
        {
            String sqlQuery = String.Format("delete * from dbo.product_details Where name={0}", pid);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        private static EAD_Project.Models.product_details FillDTO(SqlDataReader reader)
        {
            var dto = new EAD_Project.Models.product_details();
            dto.name = reader.GetString(0);
            dto.email = reader.GetString(1);
            dto.textarea_text = reader.GetString(2);
            return dto;
        }
    }
}