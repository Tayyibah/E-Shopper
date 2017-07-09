using DB;
using EAD_Project.PMS.Entities;
using EAD_Project.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAD_Project.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String login, String password)
        {
            var obj = BAL.UserBO.ValidateUser(login, password);
            if (obj != null)
            {
                Session["user"] = obj;
                if (obj.IsAdmin/*.UsersType == 1*/)
                    return Redirect("~/Home/Admin");
                else
                    return Redirect("~/Home/NormalUser");
            }

            ViewBag.MSG = "Invalid Login/Password";
            ViewBag.Login = login;

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(UserDTO dto)
        {
            //User Save Logic
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            SessionManager.ClearSession();
            return RedirectToAction("Login");
        }


        [HttpGet]
        public ActionResult Login2()
        {
            return View();
        }

        [HttpPost]
        public JsonResult addToCart(EAD_Project.Models.ProductDTO dto)
        {
            var obj = EAD_Project.BAL.ProductBO.addToCart(dto);
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

                    if (obj == 0)
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

            return Json(data, JsonRequestBehavior.AllowGet);
            // return Json(data, JsonRequestBehavior.AllowGet);
        }
        private Shopping_DBEntities4 db1 = new Shopping_DBEntities4();
       
        [HttpPost]
        public ActionResult ValidateUser(User userr/*String login, String password*/)
        {
            using (Shopping_DBEntities4 db = new Shopping_DBEntities4())
            {
                var get_user = db.Users.Single(p => p.Name == userr.Name && p.Password == userr.Password);
                if (get_user != null)
                {
                    Session["UserID"] = get_user.UserID.ToString();
                   // Session["UserName"] = get_user.UserName.ToString();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or Password does not match.");
                }

            }
            return View();
            //Object data = null;

            //try
            //{
            //    var url = "";
            //    var flag = false;

            //    var obj = BAL.UserBO.ValidateUser(login, password);
            //    if (obj != null)
            //    {
            //        flag = true;
            //        //SessionManager.User = obj;

            //        //if (obj.UsersType == 1)
            //        //    url = Url.Content("~/Home/Admin");
            //        //else
            //        //    url = Url.Content("~/Home/NormalUser");
            //         SessionManager.User = obj;

            //        if (obj.IsAdmin/*.UsersType == 1*/)
            //            url = Url.Content("~/Home/Admin");
            //        else
            //            url = Url.Content("~/Home/NormalUser");
            //    }

            //    data = new
            //    {
            //        valid = flag,
            //        urlToRedirect = url
            //    };
            //}
            //catch (Exception)
            //{
            //    data = new
            //    {
            //        valid = false,
            //        urlToRedirect = ""
            //    };
            //}

            //return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}



