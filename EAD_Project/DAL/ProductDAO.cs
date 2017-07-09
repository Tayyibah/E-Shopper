using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EAD_Project.Models;
using EAD_Project.PMS.Entities;
using EAD_Project.DAL;
using PMS.DAL;

namespace EAD_Project.DAL
{
    public class ProductDAO
    {
        public static List<PMS.Entities.ProductDTO> GetProductByUserId(int id)
        {
            var query = String.Format("Select * from dbo.addToCart Where UserID={0}", id);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                List<PMS.Entities.ProductDTO> list = new List<PMS.Entities.ProductDTO>();

                var dto = new PMS.Entities.ProductDTO();
                while (reader.Read())
                {
                    dto.ProductID = reader.GetInt32(1);
                    PMS.Entities.ProductDTO P1 = GetProductById(dto.ProductID);
                    //dto = FillDTO(reader);
                    if (dto != null)
                    {                        list.Add(P1);

                    }
                }

                return list;
            }
        }
        public static List<PMS.Entities.SellDTO> GetProductForSell()
        {
            var query = String.Format("Select * from dbo.addToCart ");

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                //  List<PMS.Entities.ProductDTO> list = new List<PMS.Entities.ProductDTO>();
                List<PMS.Entities.SellDTO> list = new List<PMS.Entities.SellDTO>();
                List<PMS.Entities.ProductDTO> ProductDTOlist = new List<PMS.Entities.ProductDTO>();
                List<PMS.Entities.UserDTO> UserDTOlist = new List<PMS.Entities.UserDTO>();
                PMS.Entities.SellDTO s;
                var dto = new PMS.Entities.ProductDTO();
                var dto1 = new PMS.Entities.UserDTO();
                // dto.ProductID = reader.GetInt32(0);
                while (reader.Read())
                {
                    dto.ProductID = reader.GetInt32(1);
                    dto1.UserID = reader.GetInt32(2);
                    if (dto != null)
                    {
                        s = new PMS.Entities.SellDTO();
                        s.Users = GetUserById(dto1.UserID); UserDTOlist.Add(s.Users);
                        PMS.Entities.ProductDTO P1 = GetProductById(dto.ProductID);
                        s.Products = P1; ProductDTOlist.Add(P1);

                        list.Add(s);
                        //s.Products.Add(GetProductById(dto.ProductID));
                    }
                }
                //for (int i = 0; i < s.Count; i++)
                //{
                //    list.Add(s[i]);

                //}
               // list.Add(s);
                return list;
            }
        }

        internal static int DeleteProductFromCart(int pid, int uid)
        {
            String sqlQuery = String.Format("Delete  From  dbo.addToCart  Where ProductID={0} and UserID={1}", pid,uid);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        public static PMS.Entities.UserDTO GetUserById(int pid)
        {

            var query = String.Format("Select * from dbo.Users Where UserId={0}", pid);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                PMS.Entities.UserDTO dto = null;

                if (reader.Read())
                {
                    dto = FillDTO1(reader);
                }

                return dto;
            }
        }
        private static EAD_Project.PMS.Entities.UserDTO FillDTO1(SqlDataReader reader)
        {
            var dto = new EAD_Project.PMS.Entities.UserDTO();
            dto.UserID = reader.GetInt32(0);
            dto.Name = reader.GetString(1);
            dto.Login = reader.GetString(2);
            dto.Password = reader.GetString(3);
            dto.PictureName = reader.GetString(6);
            // dto.IsAdmin = Convert.ToBoolean(reader.GetByte(4));
            dto.IsAdmin = reader.GetSqlBoolean(4).IsTrue;
            dto.IsActive = reader.GetSqlBoolean(5).IsTrue;
            return dto;
        }

        //public static List<PMS.Entities.ProductDTO> GetProductByUserId(int id)
        //{
        //    var query = String.Format("Select * from dbo.addToCart Where UserID={0}", id);

        //    using (DBHelper helper = new DBHelper())
        //    {
        //        var reader = helper.ExecuteReader(query);
        //        List<PMS.Entities.ProductDTO> list = new List<PMS.Entities.ProductDTO>();

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
        public static int addToCart(Models.ProductDTO dto)
        {
            String sqlQuery = "";
            using (DBHelper helper = new DBHelper())
            {
                sqlQuery = String.Format("INSERT INTO dbo.addToCart(UserID, ProductID) VALUES({0},{1})",/*; Select @@IDENTITY*/
                          dto.UserID, dto.ProductID);
                var obj = helper.ExecuteScalar(sqlQuery);
            return Convert.ToInt32(obj);
            }
        }
        public static int Save(PMS.Entities.ProductDTO dto)
        {
            using (DBHelper helper = new DBHelper())
            {
                String sqlQuery = "";
                if (dto.ProductID > 0)
                {
                    sqlQuery = String.Format("Update dbo.Products Set Name='{0}',Price='{1}',PictureName='{2}',ModifiedOn='{3}',ModifiedBy='{4}' Where ProductID={5}",
                        dto.Name, dto.Price, dto.PictureName, dto.ModifiedOn, dto.ModifiedBy, dto.ProductID);
                    helper.ExecuteQuery(sqlQuery);
                    return dto.ProductID;
                }
                else
                {
                    sqlQuery = String.Format("INSERT INTO dbo.Products(Name, Price, PictureName, CreatedOn, CreatedBy,IsActive) VALUES('{0}','{1}','{2}','{3}','{4}',{5}); Select @@IDENTITY",
                        dto.Name, dto.Price, dto.PictureName, dto.CreatedOn, dto.CreatedBy, 1);

                    var obj = helper.ExecuteScalar(sqlQuery);
                    return Convert.ToInt32(obj);
                }
            }
        }
        public static PMS.Entities.ProductDTO GetProductById(int pid)
        {
            var query = String.Format("Select * from dbo.Products Where ProductID={0}", pid);

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);

                EAD_Project.PMS.Entities.ProductDTO dto = null;

                if (reader.Read())
                {
                    dto = FillDTO(reader);
                }

                return dto;
            }
        }

        public static List<PMS.Entities.ProductDTO> GetAllProducts(Boolean pLoadComments = false)
        {
            var query = "Select * from dbo.Products Where IsActive = 1;";

            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                List< PMS.Entities.ProductDTO> list = new List<PMS.Entities.ProductDTO>();

                while (reader.Read())
                {
                    var dto = FillDTO(reader);
                    if (dto != null)
                    {
                        list.Add(dto);
                    }
                }
                if (pLoadComments == true)
                {
                   // var commentsList = CommentDAO.GetAllComments();

                    var commentsList = CommentDAO.GetTopComments(20);

                    foreach (var prod in list)
                    {
                        List<PMS.Entities.CommentDTO> prodComments = commentsList.Where(c => c.ProductID == prod.ProductID).ToList();
                        prod.Comments = prodComments;
                    }
                }
                return list;
            }
        }

        public static int DeleteProduct(int pid)
        {
            String sqlQuery = String.Format("Update dbo.Products Set IsActive=0 Where ProductID={0}", pid);

            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        private static PMS.Entities.ProductDTO FillDTO(SqlDataReader reader)
        {
            var dto = new PMS.Entities.ProductDTO();
            dto.ProductID = reader.GetInt32(0);////////////////////
            dto.Name = reader.GetString(1);
            dto.Price = reader.GetInt32(2);
            dto.PictureName = reader.GetString(3);
            dto.CreatedOn = reader.GetDateTime(4);
            dto.CreatedBy = reader.GetString(5);
            if (reader.GetValue(6) != DBNull.Value)
                dto.ModifiedOn = reader.GetDateTime(6);
            if (reader.GetValue(7) != DBNull.Value)
                dto.ModifiedBy = reader.GetString(7);

            dto.IsActive = reader.GetBoolean(8);
            return dto;
        }
    }
}
//        public static int Save(PMS.Entities.ProductDTO dto)
//        {
//            using (DBHelper helper = new DBHelper())
//            {
//                String sqlQuery = "";
//                if (dto.ProductID > 0)
//                {
//                    sqlQuery = String.Format("Update dbo.Products Set Name='{0}',Price='{1}',PictureName='{2}',ModifiedOn='{3}',ModifiedBy='{4}' Where ProductID={5}",
//                        dto.Name, dto.Price, dto.PictureName, dto.ModifiedOn, dto.ModifiedBy, dto.ProductID);
//                    helper.ExecuteQuery(sqlQuery);
//                    return dto.ProductID;
//                }
//                else
//                {
//                    sqlQuery = String.Format("INSERT INTO dbo.Products(Name, Price, PictureName, CreatedOn, CreatedBy,IsActive) VALUES('{0}','{1}','{2}','{3}','{4}',{5}); Select @@IDENTITY",
//                        dto.Name, dto.Price, dto.PictureName, dto.CreatedOn, dto.CreatedBy, 1);

//                    var obj = helper.ExecuteScalar(sqlQuery);
//                    return Convert.ToInt32(obj);
//                }
//            }
//        }

//        public static int Save(Models.ProductDTO dto)
//        {
//            String sqlQuery = "";
//            if (dto.ProductID > 0)
//            {
//                sqlQuery = String.Format("Update dbo.Products Set Name='{0}',Price='{1}',PictureName='{2}',ModifiedOn='{3}',ModifiedBy='{4}'Category={5} Where ProductID={5}",
//                    dto.Name, dto.Price, dto.PictureName, dto.ModifiedOn, dto.ModifiedBy, dto.ProductID, dto.Category);
//            }
//            else
//            {
//                sqlQuery = String.Format("INSERT INTO dbo.Products(Name, Price, PictureName, CreatedOn, CreatedBy,IsActive,Category) VALUES('{0}','{1}','{2}','{3}','{4}',{5},{6})",
//                    dto.Name, dto.Price, dto.PictureName, dto.CreatedOn, dto.CreatedBy, 1, dto.Category);
//            }

//            using (DBHelper helper = new DBHelper())
//            {
//                return helper.ExecuteQuery(sqlQuery);
//            }
//        }
//        public static Models.ProductDTO GetProductById(int pid)
//        {
//            var query = String.Format("Select * from dbo.Products Where ProductId={0}", pid);

//            using (DBHelper helper = new DBHelper())
//            {
//                var reader = helper.ExecuteReader(query);

//                Models.ProductDTO dto = null;

//                if (reader.Read())
//                {
//                    dto = FillDTO(reader);
//                }

//                return dto;
//            }
//        }

//        //public static List<ProductDTO> GetAllProducts()
//        //{
//        //    var query = "Select * from dbo.Products Where IsActive = 1;";

//        //    using (DBHelper helper = new DBHelper())
//        //    {
//        //        var reader = helper.ExecuteReader(query);
//        //        List<ProductDTO> list = new List<ProductDTO>();

//        //        while (reader.Read())
//        //        {
//        //            var dto = FillDTO(reader);
//        //            if (dto != null)
//        //            {
//        //                list.Add(dto);
//        //            }
//        //        }

//        //        return list;
//        //    }
//        //}

//        public static List<Models.ProductDTO> GetAllProducts(Boolean pLoadComments = false)
//        {
//            var query = "Select * from dbo.Products Where IsActive = 1;";

//            using (DBHelper helper = new DBHelper())
//            {
//                var reader = helper.ExecuteReader(query);
//                List<Models.ProductDTO> list = new List<Models.ProductDTO>();

//                while (reader.Read())
//                {
//                    var dto = FillDTO(reader);
//                    if (dto != null)
//                    {
//                        list.Add(dto);
//                    }
//                }
//                if (pLoadComments == true)
//                {
//                    //var commentsList = CommentDAO.GetAllComments();

//                    var commentsList = CommentDAO.GetTopComments(2);

//                    foreach (var prod in list)
//                    {
//                        List<Models.CommentDTO> prodComments = commentsList.Where(c => c.ProductID == prod.ProductID).ToList();
//                        prod.Comments = prodComments;
//                    }
//                }
//                return list;
//            }
//        }

//        public static int DeleteProduct(int pid)
//        {
//            String sqlQuery = String.Format("Update dbo.Products Set IsActive=0 Where ProductID={0}", pid);

//            using (DBHelper helper = new DBHelper())
//            {
//                return helper.ExecuteQuery(sqlQuery);
//            }
//        }

//        private static Models.ProductDTO FillDTO(SqlDataReader reader)
//        {
//            var dto = new Models.ProductDTO();
//            dto.ProductID = reader.GetInt32(5);
//            dto.Name = reader.GetString(0);
//            dto.Price = reader.GetInt32(1);
//            dto.PictureName = reader.GetString(2);
//            dto.CreatedOn = reader.GetDateTime(6);
//            dto.CreatedBy = reader.GetString(7);
//            if (reader.GetValue(3) != DBNull.Value)
//                dto.ModifiedOn = reader.GetDateTime(3);
//            if (reader.GetValue(4) != DBNull.Value)
//                dto.ModifiedBy = reader.GetString(4);
//            dto.IsActive = reader.GetBoolean(8);
//            dto.Category = reader.GetInt32(9);
//            // dto.isActive = reader.GetSqlBoolean(6).IsTrue;
//            return dto;
//        }
//    }
//}
