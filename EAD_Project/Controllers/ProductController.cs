using EAD_Project.Models;
using EAD_Project.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace EAD_Project.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        private ActionResult GetUrlToRedirect()
        {
            if (SessionManager.IsValidUser)
            {
                if (SessionManager.User/*.UsersType == 2*/.IsAdmin == false)
                {
                    TempData["Message"] = "Unauthorized Access";
                    return Redirect("~/Home/login");
                }
            }
            else
            {
                TempData["Message"] = "Unauthorized Access";
                return Redirect("~/Home/login");
            }

            return null;
        }
        public ActionResult ShowAll()
        {
            if (SessionManager.IsValidUser == false)
            {
                return Redirect("~/Home/login");
            }

            var products = BAL.ProductBO.GetAllProducts(true);

            return View(products);
        }

        public ActionResult New()
        {
            var redVal = GetUrlToRedirect();
            if (redVal == null)
            {
                var dto = new ProductDTO();
                redVal = View(dto);
            }

            return redVal;
        }

        public ActionResult Edit(int id)
        {

            var redVal = GetUrlToRedirect();
            if (redVal == null)
            {
                var prod = BAL.ProductBO.GetProductById(id);
                redVal = View("New", prod);
            }

            return redVal;

        }
        public ActionResult DeleteProductFromCart(int id)
        {

            //if (SessionManager.IsValidUser)
            //{

            //    if (SessionManager.User.IsAdmin == true)
            //    {
            //        TempData["Message"] = "Unauthorized Access";
            //        return Redirect("~/Home/NormalUser");
            //    }
            //}
            //else
            //{
            //    return Redirect("~/User/Login");
            //}

            int uid = EAD_Project.Security.SessionManager.User.UserID;
            BAL.ProductBO.DeleteProductFromCart(id,uid);
            TempData["Msg"] = "Record is deleted!";
            //return View();
            return Redirect("~/Home/user_cart");
          //  return RedirectToAction("Home/user_cart");
        }
        public ActionResult Edit2(int ProductID)
        {
            var prod = BAL.ProductBO.GetProductById(ProductID);
            return View("New", prod);
        }
        public ActionResult Delete(int id)
        {

            if (SessionManager.IsValidUser)
            {

                if (SessionManager.User.IsAdmin==false)
                {
                    TempData["Message"] = "Unauthorized Access";
                    return Redirect("~/Home/NormalUser");
                }
            }
            else
            {
                return Redirect("~/Home/Login");
            }

            BAL.ProductBO.DeleteProduct(id);
            TempData["Msg"] = "Record is deleted!";
           // return RedirectToAction("ShowAll");
            return Redirect("~/Product2/New");
        }
        [HttpPost]
        public ActionResult Save(PMS.Entities.ProductDTO dto)//////////////////////////////
        {

            if (SessionManager.IsValidUser)
            {

                if (SessionManager.User.IsAdmin==false/*.IsAdmin == false*/)
                {
                    TempData["Message"] = "Unauthorized Access";
                    return Redirect("~/Home//NormalUser");
                }
            }
            else
            {
                return Redirect("~/Home/login");
            }


            var uniqueName = "";

            if (Request.Files["Image"] != null)
            {
                var file = Request.Files["Image"];
                if (file.FileName != "")
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);

                    //Generate a unique name using Guid
                    uniqueName = Guid.NewGuid().ToString() + ext;

                    //Get physical path of our folder where we want to save images
                    var rootPath = Server.MapPath("~/UploadedFiles");

                    var fileSavePath = System.IO.Path.Combine(rootPath, uniqueName);

                    // Save the uploaded file to "UploadedFiles" folder
                    file.SaveAs(fileSavePath);

                    dto.PictureName = uniqueName;
                }
            }



            //if (dto.ProductID > 0)
            //{
            //    dto.ModifiedOn = DateTime.Now;
            //    dto.ModifiedBy = "1";
            //}
            //else
            //{
            //    dto.CreatedOn = DateTime.Now;
            //    dto.CreatedBy = "1";
            //}

            BAL.ProductBO.Save(dto);

            TempData["Msg"] = "Record is saved!";

          //  return RedirectToAction("ShowAll");
            return Redirect("~/Product2/New");
        }

    }
}