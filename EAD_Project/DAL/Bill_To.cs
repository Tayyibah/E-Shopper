using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;

namespace EAD_Project.DAL
{
    public class Bill_To
    {
        public static int Save(EAD_Project.Models.Bill_To dto)
        {
            
            String sqlQuery = "";
            sqlQuery = String.Format("INSERT INTO dbo.Bill_To(Display_Name,User_Name,Password ,confirm_password,Company_Name,Email,Title,First_Name,Middle_Name,Last_Name,Address_1,Address_2,Zip,Country,State,Phone1,Phone2,Mobile_Phone,Fax,message,Shipping) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')",
               dto.Display_Name, dto.User_Name, dto.Password, dto.confirm_password, dto.Company_Name, dto.Email, dto.Title, dto.First_Name, dto.Middle_Name, dto.Last_Name, dto.Address_1, dto.Address_2, dto.Zip, dto.Country, dto.State, dto.Phone1, dto.Phone2, dto.Mobile_Phone, dto.Fax, dto.message, dto.Shipping);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        //public static int Update(EAD_Project.Models.Bill_To dto)
        //{
        //    String sqlQuery = "";
        //    sqlQuery = String.Format("Update dbo.Bill_To Set Login='{0}',Password='{1}',Designation='{2}',Email='{3}',isActive='{4}',UsersType = {5} WHERE UserId='{6}')",
        //       dto.Login, dto.Password, dto.Designation, dto.Email, dto.isActive, dto.UsersType, dto.UserId);
        //    using (DBHelper helper = new DBHelper())
        //    {
        //        return helper.ExecuteQuery(sqlQuery);
        //    }
        //}

        //public static EAD_Project.Models.Bill_To GetUserById(int pid)
        //{

        //    var query = String.Format("Select * from dbo.Bill_To Where UserId={0}", pid);

        //    using (DBHelper helper = new DBHelper())
        //    {
        //        var reader = helper.ExecuteReader(query);

        //        Bill_To dto = null;

        //        if (reader.Read())
        //        {
        //            dto = FillDTO(reader);
        //        }

        //        return dto;
        //    }
        //}
        //public static List<EAD_Project.Models.Bill_To> GetAllUser()
        //{
        //    using (DBHelper helper = new DBHelper())
        //    {
        //        var query = "Select * from dbo.Bill_To Where IsActive = 1;";
        //        var reader = helper.ExecuteReader(query);
        //        List<EAD_Project.Models.Bill_To> list = new List<EAD_Project.Models.Bill_To>();

        //        while (reader.Read())
        //        {
        //            var dto = FillDTO(reader);
        //            if (dto != null)
        //            {
        //                list.Add(dto);
        //            }
        //        }

        //        return list;
        //    }
        //}

        //public static int DeleteUser(int pid)
        //{
        //    String sqlQuery = String.Format("Update dbo.Bill_To Set IsActive=0 Where UserId={0}", pid);

        //    using (DBHelper helper = new DBHelper())
        //    {
        //        return helper.ExecuteQuery(sqlQuery);
        //    }
        //}

        private static EAD_Project.Models.Bill_To FillDTO(SqlDataReader reader)
        {
            //Company_Name,Email,Title,First_Name,Middle_Name,Last_Name,Address_1,Address_2,Zip,Country,State,Confirm_password,Phone,Mobile_Phone,Fax,message,Shipping
            //BillNo,Display_Name,User_Name,Password ,confirm_password,Company_Name,Email,Title,First_Name,Middle_Name,Last_Name,Address_1,Address_2,Zip,Country,State,Phone1,Phone2,Mobile_Phone,Fax,message,Shipping *@

            var dto = new EAD_Project.Models.Bill_To();
            dto.BillNo = reader.GetInt32(0);
            dto.Display_Name = reader.GetString(0);
            dto.User_Name = reader.GetString(0);
            dto.Password = reader.GetString(0);
            dto.confirm_password = reader.GetString(0);
            dto.Email = reader.GetString(1);
            dto.Title = reader.GetString(2);
            dto.First_Name = reader.GetString(3);
            dto.Middle_Name = reader.GetString(4);
            dto.Last_Name = reader.GetString(5);
            dto.Address_1 = reader.GetString(6);
            dto.Address_2 = reader.GetString(7);
            dto.Zip = reader.GetString(8);
            dto.Country = reader.GetString(9);
            dto.State = reader.GetString(10);
            dto.Phone1 = reader.GetString(11);
            dto.Phone2 = reader.GetString(12);
            dto.Mobile_Phone = reader.GetString(13);
            dto.Fax = reader.GetString(14);
            dto.message = reader.GetString(15);
            dto.Shipping = reader.GetString(16);
            return dto;
        }
    }
}