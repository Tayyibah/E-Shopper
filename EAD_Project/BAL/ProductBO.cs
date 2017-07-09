using EAD_Project.DAL;
using EAD_Project.PMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class ProductBO
    {
       
        public static int addToCart(Models.ProductDTO dto)
        {
            return ProductDAO.addToCart(dto);
        }
        public static int Save(ProductDTO dto)
        {
            return ProductDAO.Save(dto);
        }
        public static ProductDTO GetProductById(int pid)
        {
            return ProductDAO.GetProductById(pid);
        }
        public static List<ProductDTO> GetAllProducts(Boolean pLoadComments = false)
        {
            return ProductDAO.GetAllProducts(true);
        }
        public static List<SellDTO> GetProductForSell()
        {
            return ProductDAO.GetProductForSell();
        }
        public static List<ProductDTO> GetProductByUserId(int id)
        {
            return ProductDAO.GetProductByUserId(id);
        }

        public static int DeleteProduct(int pid)
        {
            return ProductDAO.DeleteProduct(pid);
        }
        public static int DeleteProductFromCart(int pid, int uid)
        {
            return ProductDAO.DeleteProductFromCart(pid, uid);
        }
        
    }
}

//        public static int Save(EAD_Project.Models.ProductDTO dto)
//        {
//            return DAL.ProductDAO.Save(dto);
//        }
//        public static EAD_Project.Models.ProductDTO GetProductById(int pid)
//        {
//            return DAL.ProductDAO.GetProductById(pid);
//        }
//        public static List<EAD_Project.Models.ProductDTO> GetAllProducts()
//        {
//            return DAL.ProductDAO.GetAllProducts();
//        }

//        public static int DeleteProduct(int pid)
//        {
//            return DAL.ProductDAO.DeleteProduct(pid);
//        }
//        public static int Save(ProductDTO dto)
//        {
//            return DAL.ProductDAO.Save(dto);
//        }
//        //public static ProductDTO GetProductById(int pid)
//        //{
//        //    return DAL.ProductDAO.GetProductById(pid);
//        //}
//        //public static List<ProductDTO> GetAllProducts()
//        //{
//        //    return DAL.ProductDAO.GetAllProducts();
//        //}

//        //public static int DeleteProduct(int pid)
//        //{
//        //    return DAL.ProductDAO.DeleteProduct(pid);
//        //}
//    }
//}
