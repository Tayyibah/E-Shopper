using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;


namespace EAD_Project.DAL
{
    public class cart
    {
        public static int Save(EAD_Project.Models.cart dto)
        {
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.cart(user_option,single_fieldCountry,single_field_Region, Zip_Code) VALUES('{0}','{1}','{2}','{3}')",
               dto.user_option, dto.single_fieldCountry, dto.single_field_Region, dto.Zip_Code);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        public static EAD_Project.Models.cart GetUserById(int pid)
        {

            var query = String.Format("Select * from dbo.cart Where UserId={0}", pid);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.Models.cart dto = null;

                if (reader.Read())
                {
                    dto = FillDTO(reader);
                }

                return dto;
            }
        }
        public static List<EAD_Project.Models.cart> GetAllUser()
        {
            using (DBHelper helper = new DBHelper())
            {
                var query = "Select * from dbo.cart";
                var reader = helper.ExecuteReader(query);
                List<EAD_Project.Models.cart> list = new List<EAD_Project.Models.cart>();

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

        public static int DeleteUser()
        {
            String sqlQuery = String.Format("delete * from dbo.cart");

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        private static EAD_Project.Models.cart FillDTO(SqlDataReader reader)
        {
            var dto = new EAD_Project.Models.cart();
            dto.user_option = reader.GetString(0);
            dto.single_fieldCountry = reader.GetString(1);
            dto.single_field_Region = reader.GetString(2);
            dto.Zip_Code = reader.GetString(3);
            return dto;
        }
    }
}