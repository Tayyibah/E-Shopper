using DB;
using EAD_Project.Models;
using EAD_Project.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAD_Project.Controllers
{
    public class Product2Controller : Controller
    {
        public ActionResult New()
        {
            return View();
        }
        public ActionResult v_New()
        {
            return View();
        }
        public ActionResult user_cart()
        {
            return View();
        }

        public JsonResult GetAllProducts()
        {
            var products = EAD_Project.BAL.ProductBO.GetAllProducts(true);

            var d = new
            {
                data = products
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetProductById(int pid)
        {
            var prod = EAD_Project.BAL.ProductBO.GetProductById(pid);
            var d = new
            {
                data = prod
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetProductForSell()
        {
            var products = EAD_Project.BAL.ProductBO.GetProductForSell();

            var d = new
            {
                data = products
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult GetProductByUserId()
        {
            int pid = EAD_Project.Security.SessionManager.User.UserID; int total = 0;
            var prod = EAD_Project.BAL.ProductBO.GetProductByUserId(pid);
            foreach(var x in prod)
            {
                total = total+ x.Price;
            }
            ViewBag.total = total;
            ViewData["total"] = total;
            Session["Product"] = prod;
            using (var context = new Shopping_DBEntities4())
            {
                var student = new DB.Bill_To
                {
                    UserID = EAD_Project.Security.SessionManager.User.UserID,
                     Total= total
                };
                context.Bill_To.Add(student);
                context.SaveChanges();
            }
                var d = new
            {
                data = prod
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteProduct(int pid)
        {
            EAD_Project.BAL.ProductBO.DeleteProduct(pid);
            var data = new
            {
                success = true
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult DeleteProductFromCart(int pid)
        {
            int uid = EAD_Project.Security.SessionManager.User.UserID;
            EAD_Project.BAL.ProductBO.DeleteProductFromCart(pid,uid);
            var data = new
            {
                success = true
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult mmm()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save(PMS.Entities.ProductDTO dto)
        {
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

            var pid = EAD_Project.BAL.ProductBO.Save(dto);

            var data = new
            {
                success = true,
                ProductID = pid,
                PictureName = dto.PictureName
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult addToCart(EAD_Project.Models.ProductDTO dto)
        {
            var obj=EAD_Project.BAL.ProductBO.addToCart(dto);
            //var data = new
            //{
            //    success = true,
            //    UserID = SessionManager.User.Name,
            //    PictureName = SessionManager.User.PictureName
            //};
            //return Json(data, JsonRequestBehavior.AllowGet);

            //var data = new
            //{
            //    success = true
            //};


            Object data = null;

            try
            {
                var url = "";
                var flag = false;
                if (obj == 0)
                {
                    flag = true;
                    //SessionManager.User = obj;

                    //if (obj.UsersType == 1)
                    //    url = Url.Content("~/Home/Admin");
                    //else
                    //    url = Url.Content("~/Home/NormalUser");



                    //SessionManager.User = obj;

                    if (obj==0)
                        url = Url.Content("~/Product2/New");
                }

                data = new
                {
                    valid = flag,
                    urlToRedirect = url
                };
            }
            catch (Exception)
            {
                data = new
                {
                    valid = false,
                    urlToRedirect = ""
                };
            }

            //   return Json(data, JsonRequestBehavior.AllowGet);

            // return Content("<script>alert('Product is added to cart successfully);document.location='~/Home/user_cart'</script>");
            // return Json(data, JsonRequestBehavior.AllowGet);
            return Content("<script>alert('Product added successfully!!!');document.location='New '</script>");
        }
        [HttpPost]
        public JsonResult SaveComment(EAD_Project.PMS.Entities.CommentDTO dto)
        {
            dto.CommentOn = DateTime.Now;
            dto.UserID = SessionManager.User.UserID/*.UserId*/;
            dto.UserName = SessionManager.User.Name;
            dto.PictureName = SessionManager.User.PictureName;

            EAD_Project.BAL.CommentBO.Save(dto);
            var data = new
            {
                success = true,
                UserName = SessionManager.User.Name,
                CommentOn = dto.CommentOn,
                PictureName = SessionManager.User.PictureName
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        //// GET: Product2
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult New()
        //{
        //    return View();
        //}

        //public JsonResult GetAllProducts()
        //{
        //    var products =BAL.ProductBO.GetAllProducts();

        //    var d = new
        //    {
        //        data = products
        //    };
        //    return Json(d, JsonRequestBehavior.AllowGet);
        //}


        //public JsonResult GetProductById(int pid)
        //{
        //    var prod = BAL.ProductBO.GetProductById(pid);
        //    var d = new
        //    {
        //        data = prod
        //    };
        //    return Json(d, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public JsonResult DeleteProduct(int pid)
        //{
        //    BAL.ProductBO.DeleteProduct(pid);
        //    var data = new
        //    {
        //        success = true
        //    };
        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public JsonResult Save(ProductDTO dto)
        //{
        //    var uniqueName = "";

        //    if (Request.Files["Image"] != null)
        //    {
        //        var file = Request.Files["Image"];
        //        if (file.FileName != "")
        //        {
        //            var ext = System.IO.Path.GetExtension(file.FileName);

        //            //Generate a unique name using Guid
        //            uniqueName = Guid.NewGuid().ToString() + ext;

        //            //Get physical path of our folder where we want to save images
        //            var rootPath = Server.MapPath("~/UploadedFiles");

        //            var fileSavePath = System.IO.Path.Combine(rootPath, uniqueName);

        //            // Save the uploaded file to "UploadedFiles" folder
        //            file.SaveAs(fileSavePath);

        //            dto.PictureName = uniqueName;
        //        }
        //    }


        //    if (dto.ProductID > 0)
        //    {
        //        dto.ModifiedOn = DateTime.Now;
        //        dto.ModifiedBy = "1";
        //    }
        //    else
        //    {
        //        dto.CreatedOn = DateTime.Now;
        //        dto.CreatedBy = "1";
        //    }

        //    var pid = BAL.ProductBO.Save(dto);

        //    var data = new
        //    {
        //        success = true,
        //        ProductID = pid,
        //        PictureName = dto.PictureName
        //    };
        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}

    }
}