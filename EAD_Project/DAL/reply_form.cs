using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;

using System.Web;

namespace EAD_Project.DAL
{
    public class reply_form
    {
        public static int Save(EAD_Project.Models.reply_form dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.reply_form(name,email,website,message) VALUES('{0}','{1}','{2}','{3}')",
               dto.name, dto.email, dto.website, dto.message);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        public static List<EAD_Project.Models.reply_form> GetAllUser()
        {
            using (DBHelper helper = new DBHelper())
            {
                var query = "Select * from dbo.reply_form ";
                var reader = helper.ExecuteReader(query);
                List<EAD_Project.Models.reply_form> list = new List<EAD_Project.Models.reply_form>();

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

        private static EAD_Project.Models.reply_form FillDTO(SqlDataReader reader)
        {
            //name,email,website,message
            var dto = new EAD_Project.Models.reply_form();
            dto.name = reader.GetString(0);
            dto.email = reader.GetString(1);
            dto.website = reader.GetString(2);
            dto.message = reader.GetString(3);
            return dto;
        }
    }
}