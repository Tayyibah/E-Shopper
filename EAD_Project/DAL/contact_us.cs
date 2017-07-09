using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;


namespace EAD_Project.DAL
{
    public class contact_us
    {
        public static int Save(EAD_Project.Models.contact_us dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.contact_us(name,email,subject,message) VALUES('{0}','{1}','{2}','{3}')",
               dto.name, dto.email, dto.subject, dto.message);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        public static EAD_Project.Models.contact_us GetUserById(string pid)
        {

            var query = String.Format("Select * from dbo.contact_us Where email='{0}'", pid);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.Models.contact_us dto = null;

                if (reader.Read())
                {
                    dto = FillDTO(reader);
                }

                return dto;
            }
        }
        public static List<EAD_Project.Models.contact_us> GetAllUser()
        {
            using (DBHelper helper = new DBHelper())
            {
                var query = "Select * from dbo.contact_us";
                var reader = helper.ExecuteReader(query);
                List<EAD_Project.Models.contact_us> list = new List<EAD_Project.Models.contact_us>();

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
        private static EAD_Project.Models.contact_us FillDTO(SqlDataReader reader)
        {
            var dto = new EAD_Project.Models.contact_us();
            dto.name = reader.GetString(0);
            dto.email = reader.GetString(1);
            dto.subject = reader.GetString(2);
            dto.message = reader.GetString(3);
            return dto;
        }
    }
}