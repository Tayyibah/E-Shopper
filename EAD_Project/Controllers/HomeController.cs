using DB;
using EAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EAD_Project.Security;
using System.Web.Mvc;
using EAD_Project.BAL;
using EAD_Project.Views.Home;

namespace EAD_Project.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult zz( )
        {

            return View();
        }
        [HttpPost]
        public ActionResult feedBackServlet(Models.feedback u)
        {
            using (var context = new Shopping_DBEntities4())
            {
                var student = new DB.feedback
                {
                    email = u.email,
                    message = u.message,
                };
                context.feedbacks.Add(student);
                context.SaveChanges();
                return Content("<script>alert('Thanks for ur feedback!!');document.location='About'</script>");
            }
        }





        [HttpPost]
        public ActionResult Login(EAD_Project.PMS.Entities.UserDTO u)
        {
            Shopping_DBEntities4 db = new Shopping_DBEntities4();
            var query = from d in db.Users
                        where (d.Password == u.Password && d.Name == u.Name)
                        select d;
            if (query!=null)
            {
                var q = query.ToList();
            foreach (var x in q)
                u.IsAdmin = (bool)x.isAdmin;
            Models.UserDTO result = new Models.UserDTO();
            result.IsAdmin = u.IsAdmin;
            EAD_Project.PMS.Entities.UserDTO obj = UserBO.ValidateUser(u.Name, u.Password);
            foreach (var x in q)
            {
                if (query != null)
                {
                    Session["User"] = obj;
                    if (result.IsAdmin)
                        //return Redirect("~/Home/Admin");
                        return RedirectToAction("Admin");
                    else
                        return RedirectToAction("NormalUser");
                }
            }
            //else
            //{

            ViewBag.MSG = "Invalid Login/Password";
            ViewBag.Login = u.Login;
            ModelState.AddModelError("", "UserName or Password does not match.");
           // return RedirectToAction("Login");
            return Content("<script>alert('invalid user name or password');document.location='Login'</script>");
                //}
            }
            return Content("<script>alert('invalid user name or password');document.location='Login'</script>");
        }
        private static Boolean ValidateUser(User u)
        {
            using (var context = new Shopping_DBEntities4())
            {
                var student = (from d in context.Users
                               where d.Password == u.Password && d.Name == u.Name
                               select d).Single();
                if (student != null)
                    return true;
                else
                    return false;
            }
        }

        private static void AddStudent(User u)
        {
            using (var context = new Shopping_DBEntities4())
            {
                var student = new User
                {
                    Name = u.Name,
                    Login = u.Name,
                    Password = u.Password,
                    PictureName = u.PictureName,
                    Designation = u.Designation,
                    Email = u.Email,
                    isAdmin = false,
                    isActive = true
                };
                context.Users.Add(student);
                context.SaveChanges();
            }
        }

        private static void ChangeStudent(User u)
        {
            using (var context = new Shopping_DBEntities4())
            {
                var student = (from d in context.Users
                               where d.UserID == u.UserID && d.Login == u.Login
                               select d).Single();

                student.Password = "Aslam";
                context.SaveChanges();
            }
        }
        private static void DeleteStudent(User u)
        {
            using (var context = new Shopping_DBEntities4())
            {
                var bay = (from d in context.Users
                           where d.UserID == u.UserID
                           select d).Single();
                context.Users.Remove(bay);
                context.SaveChanges();
            }
        }
        private Shopping_DBEntities4 db1 = new Shopping_DBEntities4();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Abosut()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       

        public void email()
        {
            String toAddress = "";
            String subject = "";
            String body = "";

            Boolean result = EmailHandler.SendEmail(toAddress, subject, body);

            if (result == false)
            {
                Console.WriteLine("Unable to send email");
            }
            else
            {
                Console.WriteLine("Email Sent!");
            }
        }


        public ActionResult sendEmail()
        {
            email();
            return View();
        }
        public ActionResult LoginAndSignup()
        {
            email();
            return View();
        }

        public ActionResult updatePassword()
        {
            String email = Request.QueryString["email"];
            String code = Request.QueryString["code"];
            // String code = Request.QueryString["code"].ToString();
            EAD_Project.PMS.Entities.UserDTO obj = BAL.UserBO.checkIsUser(email);
            if (obj.UserID > 0)
                return RedirectToAction("updatePassword1", "Home", obj);
            else
                return Content("<script language='javascript' type='text/javascript'>alert('User don't exist!');</script>");
        }
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult updatePassword1(String password)
        {
           // string demo = Sanitizer.GetSafeHtmlFragment(password);
            UserDTO u = new UserDTO();
            String Login = Request["Email"].ToString();
            String code = Request["CodeForReset"].ToString();
            String Password = Request["Password"].ToString();
            var obj = BAL.UserBO.updatePassword(Login, Password);
            if (obj >0)
                return Content("<script language='javascript' type='text/javascript'>alert('Password Updated Suuccessfully !');</script>");
            else
                return Content("<script language='javascript' type='text/javascript'>alert('Process Unsuccessfull!');</script>");
        }
        //[HttpGet]
        //public ActionResult updatePassword1(UserDTO u)
        //{
        //    ViewData["Login"] = u.Login;
        //    ViewBag.Login = u.Login;
        //    ViewBag.CodeForReset = u.CodeForReset;
        //    return View();
        //}

        public ActionResult forgotPassword()
        {

            return View();
        }
        public ActionResult forgetPassword()
        {

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult admin2()
            {
                return View();
            }
        public ActionResult Signup()
        {
            Models.UsersTable u = new Models.UsersTable();
            //u.UserId =Convert.ToInt32(Request["UserId"]);
            u.Login = Request["name"];
            u.Password = Request["Password"];
            u.Designation = Request["Designation"];
            u.Email = Request["Email"];
            u.isActive = true /*Convert.ToBoolean(Request["isActive"])*/;
            u.UsersType = 2 /*Convert.ToInt32(Request["UsersType"])*/;
            var obj = UserBO.Save(u);
            if (obj > 0)
            {
               
                return Content("<script>alert('Thanks for Registering!');document.location='NormalUser'</script>");
                //return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                // int i = 0;
               // Session["user"] = obj;
            }
            else

                return Content("<script>alert('invalid user name or password');document.location='login'</script>");
           // return View();
        }

        [HttpPost]
        public /*JsonResult*/ActionResult SaveUsers(User u)
        {

            string password = Request["password1"];
            string password2 = Request["cn_password"];
            if (password != password2)
                return Content("<script>alert('Password mismatch!!!');var data = new{success = false};document.location='login'</script>");

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
                    var rootPath = Server.MapPath("~/App_Data/UploadedFiles");

                    var fileSavePath = System.IO.Path.Combine(rootPath, uniqueName);

                    // Save the uploaded file to "UploadedFiles" folder
                    file.SaveAs(fileSavePath);

                    u.PictureName = uniqueName;
                }
            }
            using (var context = new Shopping_DBEntities4())
            {
                var student = new DB.User
                {
                    Name = u.Name,
                    Login = u.Name,
                    Password = password,
                    isAdmin = false,
                    isActive = true,
                    PictureName = u.PictureName,
                    Designation = u.Designation,
                    Email = u.Email

                };
                context.Users.Add(student);
                context.SaveChanges();
                var data = new
                {
                    success = true,
                    //ProductID = pid,
                    //PictureName = u.PictureName
                };
                if (student != null)
                    // return Json(data, JsonRequestBehavior.AllowGet); return Json(data, JsonRequestBehavior.AllowGet);
                    return Content("<script>alert('thanks for registering!!!'); var data = new{success = true}; document.location='NormalUser'</script>");
                // return View();
                else
                    return Content("<script>alert('registering unsuccessful!!!'); var data = new{success = false}; document.location='NormalUser'</script>");

            }
            //   return Content("<script>alert('registering unsuccessful!!!'); var data = new{success = false}; document.location='NormalUser'</script>");

        }

        ////var pid = UserBO.SaveUsers(u);
        //var data = new
        //{
        //    success = true,
        //    //ProductID = pid,
        //    //PictureName = u.PictureName
        //};
        //return Json(data, JsonRequestBehavior.AllowGet);
        //return Content("<script>alert('thanks for registering!!!');document.location='NormalUser'</script>");

        //[HttpPost]
        //public /*JsonResult*/ActionResult SaveUsers(User u)
        //{

        //    string password = Request["password1"];
        //    string password2 = Request["cn_password"];
        //    if (password != password2)
        //        return Content("<script>alert('Password mismatch!!!');var data = new{success = false};document.location='login'</script>");

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

        //            u.PictureName = uniqueName;
        //        }
        //    }
        //        using (var context = new Shopping_DBEntities4())
        //        {
        //            var student = new DB.User
        //            {
        //                Name = u.Name,
        //                Login = u.Name,
        //                Password = password,
        //                isAdmin = false,
        //                isActive = true,
        //                PictureName = u.PictureName,
        //                Designation = u.Designation,
        //                Email = u.Email

        //            };
        //        context.Users.Add(student);
        //        context.SaveChanges();
        //        var data = new
        //        {
        //            success = true,
        //            //ProductID = pid,
        //            //PictureName = u.PictureName
        //        };
        //        if (student != null)
        //           // return Json(data, JsonRequestBehavior.AllowGet); return Json(data, JsonRequestBehavior.AllowGet);
        //        return Content("<script>alert('thanks for registering!!!'); var data = new{success = true}; document.location='NormalUser'</script>");
        //       // return View();
        //        else
        //            return Content("<script>alert('registering unsuccessful!!!'); var data = new{success = false}; document.location='NormalUser'</script>");

        //    }
        // //   return Content("<script>alert('registering unsuccessful!!!'); var data = new{success = false}; document.location='NormalUser'</script>");

        //}

        ////var pid = UserBO.SaveUsers(u);
        //var data = new
        //{
        //    success = true,
        //    //ProductID = pid,
        //    //PictureName = u.PictureName
        //};
        //return Json(data, JsonRequestBehavior.AllowGet);
        //return Content("<script>alert('thanks for registering!!!');document.location='NormalUser'</script>");

        [HttpPost]
        public JsonResult SaveUsers1(PMS.Entities.UserDTO u)
        {
            u.Name = Request["name"];
            u.Login = Request["name"];
            u.Password = Request["Password"];
            u.Designation = Request["Designation"];
            u.Email = Request["Email"];
            u.IsAdmin = false;
            u.IsActive = true;
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

                    u.PictureName = uniqueName;
                }
            }
            var pid = UserBO.SaveUsers(u);
            var data = new
            {
                success = true,
                ProductID = pid,
                PictureName = u.PictureName
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SignupUser()
        {
            Models.UsersTable u = new Models.UsersTable();
            //u.UserId =Convert.ToInt32(Request["UserId"]);
            u.Login = Request["name"];
            u.Password = Request["Password"];
            u.Designation = Request["Designation"];
            u.Email = Request["Email"];
            u.isActive = true /*Convert.ToBoolean(Request["isActive"])*/;
            u.UsersType = 2 /*Convert.ToInt32(Request["UsersType"])*/;
            var obj = UserBO.Save(u);
            if (obj > 0)
            {
                return Content("<script>alert('thanks for registering!!!');document.location='NormalUser'</script>");
                // int i = 0;
                // Session["user"] = obj;
            }
            else
                return Content("<script>alert('registering unsuccessful!!!');document.location='login'</script>");
        }
        public ActionResult user_cart()
        {
            int pid = EAD_Project.Security.SessionManager.User.UserID; int total = 0;
            var prod = EAD_Project.BAL.ProductBO.GetProductByUserId(pid);
            foreach (var x in prod)
            {
                total = total + x.Price;
            }
            ViewBag.total = total;
            ViewData["total"] = total;
            Session["Product"] = prod;
            return View();
        }
        [HttpPost]
        public ActionResult Bill_To(Models.Bill_To u)
        {
            using (var context = new Shopping_DBEntities4())
            {
                var student = (from d in context.Bill_To
                               where d.UserID == SessionManager.User.UserID
                               select d).ToList();
                var total = 0;
                var total1 = student.ToList();
                foreach (var x in total1)
                {
                    total = (Int32)x.Total;
                }
                ViewBag.total = total;
                ViewData["total"] = total;
                foreach (var no in total1)
                {
                    if (no != null)
                    {
                        no.Display_Name = u.Display_Name;
                        no.User_Name = u.User_Name ;
                        no.Password = u.Password;
                        no.confirm_password = u.confirm_password;
                        no.Company_Name = u.Company_Name ;
                        no.Email = u.Email ;
                        no.Title = u.Title ;
                        no.First_Name = u.First_Name ;
                        no.Middle_Name = u.Middle_Name ;
                        no.Last_Name = u.Last_Name ;
                        no.Address_1 = u.Address_1 ;
                        no.Address_2 = u.Address_2 ;
                        no.Zip = u.Zip ;
                        no.Country = u.Country ;
                        no.State = u.State ;
                        no.Phone1 = u.Phone1 ;
                        no.Phone2 = u.Phone2;
                        no.Fax = u.Mobile_Phone ;
                        no.Email = u.Fax ;
                        no.message = u.message ;
                        no.Shipping = u.Shipping ;
                        context.SaveChanges();
                        var data = new
                        {
                            success = true
                        };
                        return Content("<script>alert('checkout successful!!!'); var data = new{success = true; document.location='NormalUser'</script>");

                    }
                else
                    return View();
                }

                return View();
            }
        }
            [HttpGet]
            public ActionResult Bill_To()
            {
            using (var context = new Shopping_DBEntities4())
            {

                var student = (from d in context.Bill_To
                               where d.UserID == SessionManager.User.UserID
                               select d).Single();
                var total = 0;
                total = (Int32)student.Total;
            }
            Models.Bill_To u = new Models.Bill_To();
                u.Company_Name = Request["Company_Name"];
                u.Email = Request["Email"];
                u.Title = Request["Title"];
                u.First_Name = Request["First_Name"];
                u.Middle_Name = Request["Middle_Name"];
                u.Last_Name = Request["Last_Name"];
                u.Address_1 = Request["Address_1"];
                u.Address_2 = Request["Address_2"];
                u.Zip = Request["Zip"];
                u.Country = Request["Country"];
                u.State = Request["State"];
                u.Phone1 = Request["Confirm_password"];
                u.Phone2 = Request["Phone"];
                u.Fax = Request["Mobile_Phone"];
                u.Email = Request["Fax"];
                u.message = Request["message"];
                u.Shipping = Request["Shipping"];
                var obj = BAL.Bill_To.Save(u);
                if (obj > 0)
            {
                return Content("<script>alert('checkout successful!!!');document.location='NormalUser'</script>");
            }
            else
                    return View();
            }

        //[HttpPost]
        //public ActionResult Login(String name, String password)
        //{

        //    var obj = UserBO.ValidateUser(name, password);
        //    if (obj != null)
        //    {
        //        Session["user"] = obj;
        //        if (obj.IsAdmin /*== 1*/)
        //            return Redirect("~/Home/Admin");
        //        else
        //            return Redirect("~/Home/NormalUser");
        //    }

        //    ViewBag.MSG = "Invalid Login/Password";
        //    ViewBag.Login = name;

        //    return View();
        //}
        [HttpPost]
        public ActionResult Login1(User u)
        {
            if (ModelState.IsValid)
            {
                User t1 = new User();

                t1.Name = u.Name;
                t1.Password = u.Password;
                t1.Login = u.Login;
               
                return RedirectToAction("Index");

            }
            var obj = UserBO.ValidateUser(u.Name,u.Password);
            if (obj != null)
            {
                Session["user"] = obj;
                if (obj.IsAdmin /*== 1*/)
                    return Redirect("~/Home/Admin");
                else
                    return Redirect("~/Home/NormalUser");
            }

            ViewBag.MSG = "Invalid Login/Password";
            ViewBag.Login = u.Name;

            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    return View();
        //}
        public ActionResult Error404()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            [HttpPost]
            public ActionResult product_details_save()
            {
                ViewBag.Message = "Your application description page.";
                Models.product_details u = new Models.product_details();
                u.name = Request["name"];
                u.email = Request["email"];
                u.textarea_text = Request["textarea_text"];
                var obj = BAL.product_details.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                }
                else
                    return View();
            }
            [HttpGet]
            public ActionResult product_details_save(Models.product_details u)
            {
                ViewBag.Message = "Your application description page.";
                u = new Models.product_details();
                u.name = Request["name"];
                u.email = Request["email"];
                u.textarea_text = Request["textarea_text"];
                var obj = BAL.product_details.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                }
                else
                    return View();
            }
            public ActionResult product_details()
            {
                return View();
            }
            [HttpPost]
            public ActionResult sendemail()
            {
                //    ViewBag.Message = "Your application description page.";
                //    Models.Bill_To u = new Models.Bill_To();
                //    u.Login = Request["name"];
                //    u.Password = Request["Password"];
                //    u.Designation = Request["Designation"];
                //    u.Email = Request["Email"];
                //    var obj = BAL..Save(u);
                //    if (obj > 0)
                //    {
                //        return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                //    }
                //    else
                return View();
            }
        public ActionResult shop()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult shnnnnnnnnop()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult bbbb()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult shopNow()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult login()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            [HttpGet]
            public ActionResult contact_us_save()
            {
                ViewBag.Message = "Your application description page.";
                Models.contact_us u = new Models.contact_us();
                u.name = Request["name"];
                u.email = Request["email"];
                u.subject = Request["subject"];
                u.message = Request["message"];
                var obj = BAL.contact_us.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('message sent successfully !!');</script>");
                }
                else
                    return View("contact_us");
            }
            public ActionResult contact_us()
            {

                return View();
            }

        [HttpPost]
        public ActionResult contact_us_save(Models.contact_us u)
        {
            //ViewBag.Message = "Your application description page.";
            ///// Models.contact_us u = new Models.contact_us();
            ///// Request.Form
            //u.name = Request.Form["name"];
            //u.email = Request.Form["email"];
            //u.subject = Request.Form["subject"];
            //u.message = Request.Form["message"];
            //var obj = BAL.contact_us.Save(u);
            DB.contact_us student =null ;
            using (var context = new Shopping_DBEntities4())
            {
                student = new DB.contact_us
                {
                    name = Request.Form["name"],
                    email = Request.Form["email"],
                    subject = Request.Form["subject"],
                    message = Request.Form["message"]
                };
                context.contact_us.Add(student);
                context.SaveChanges();
            }
            if (student !=null)
            {

                //FlashMessage.Warning("Your error message");
                //return RedirectToAction("AdminUsers", "Admin");
                return Content("<script>alert('message sent successfully');document.location='contact_us'</script>");
                // return Content("<script language='javascript' type='text/javascript'>alert('message sent successfully !!');</script>");
            }
            else
                return Content("<script>alert('message not sent successfully');document.location='contact_us'</script>");

        }            
           //     DB.contact_us. student = (DB.contact_us)u;
           //// student.StudentName = "Student1";

           // using (var ctx = new Shopping_DBEntities5())
           // {
           //     ctx.contact_us.Add(u);
           //     ctx.SaveChanges();
           // }
        
            public ActionResult checkout()
            {
            //    using (var context = new Shopping_DBEntities4())
            //    {
            //        var student = (from d in context.Bill_To
            //                       where d.UserID == SessionManager.User.UserID
            //                       select d).ToList();
            //        var total=0;
            //    var total1 = student.ToList();
            //    foreach (var x in total1)
            //    {
            //        total = (Int32)x.Total;
            //    }

            //    ViewBag.total = total;
            //    ViewData["total"] = total;
            //}
            return View();
            }
            [HttpGet]
            public ActionResult checkout_save()
            {
                ViewBag.Message = "Your application description page.";
                Models.Shopper_Information u = new Models.Shopper_Information();
                u.Display_Name = Request["Display_Name"];
                u.User_Name = Request["User_Name"];
                u.password = Request["password"];
                u.password2 = Request["password2"];
                var obj = BAL.Shopper_Information.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                }
                else
                    return View();
            }
            [HttpPost]
            public ActionResult checkout_save(Models.Shopper_Information u)
            {
                ViewBag.Message = "Your application description page.";
                u = new Models.Shopper_Information();
                u.Display_Name = Request["Display_Name"];
                u.User_Name = Request["User_Name"];
                u.password = Request["password"];
                u.password2 = Request["password2"];
                var obj = BAL.Shopper_Information.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                }
                else
                    return View();
            }
            [HttpGet]
            public ActionResult reply_form()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            [HttpPost]
            public ActionResult reply_form(EAD_Project.Models.reply_form u)
            {
                ViewBag.Message = "Your application description page.";
                u = new Models.reply_form();
                u.name = Request["name"];
                u.email = Request["email"];
                u.website = Request["website"];
                u.message = Request["message"];
                var obj = BAL.reply_form.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                }
                else
                    return View();
            }
            public ActionResult blog_single()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            public ActionResult cart()
            {
                //ViewBag.Message = "Your application description page.";
                //Models.cart u = new Models.cart();
                //u.user_option = Request["user_option"];
                //u.single_fieldCountry = Request["single_fieldCountry"];
                //u.single_field_Region = Request["single_field_Region"];
                //u.Zip_Code = Request["Zip_Code"];
                //var obj = BAL.cart.Save(u);
                //if (obj > 0)
                //{
                //    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                //}
                //else
                return View();
            }
            [HttpGet]
            public ActionResult cart_save()
            {
                ViewBag.Message = "Your application description page.";
                Models.cart u = new Models.cart();
                u.user_option = Request["user_option"];
                u.single_fieldCountry = Request["single_fieldCountry"];
                u.single_field_Region = Request["single_field_Region"];
                u.Zip_Code = Request["Zip_Code"];
                var obj = BAL.cart.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                }
                else
                    return View();
            }
            [HttpPost]
            public ActionResult cart_save(Models.cart u)
            {
                ViewBag.Message = "Your application description page.";
                u = new Models.cart();
                u.user_option = Request["user_option"];
                u.single_fieldCountry = Request["single_fieldCountry"];
                u.single_field_Region = Request["single_field_Region"];
                u.Zip_Code = Request["Zip_Code"];
                var obj = BAL.cart.Save(u);
                if (obj > 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Registering!');</script>");
                }
                else
                    return View();
            }
        public ActionResult blog()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult shopper()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Update_Products()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            public ActionResult Customer_Reviews()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            public ActionResult Customer_Orders()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            public ActionResult Admin()
            {
                if (SessionManager.IsValidUser)
                {

                    if (SessionManager.User.IsAdmin/*.UsersType == 1*/)
                    {
                       return View();
                    //
                  //  return Redirect("/Product2/New");
                }
                    else
                    {
                        return RedirectToAction("NormalUser");
                    }
                }
                else
                {
                    return Redirect("~/Home/Login");
                }
            }
            public ActionResult NormalUser()
            {
                if (SessionManager.IsValidUser)
                {

                    if (SessionManager.User.IsAdmin)
                    {
                        return RedirectToAction("Admin");
                    }
                    else
                    {
                    return View();
                        // return View();
                    }
                }
                else
                {
                    return Redirect("~/Home/Index");
                }
            }
        [HttpPost]
        public JsonResult Save(Models.UsersTable u)
        {
            //u.UserId =Convert.ToInt32(Request["UserId"]);
            u.Login = Request["name"];
            u.Password = Request["Password"];
            u.Designation = Request["Designation"];
            u.Email = Request["Email"];
            u.isActive = true /*Convert.ToBoolean(Request["isActive"])*/;
            u.UsersType = 1 /*Convert.ToInt32(Request["UsersType"])*/;
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

                    u.PictureName = uniqueName;
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
            
            var pid = UserBO.Save(u);
            var data = new
            {
                success = true,
                ProductID = pid,
                PictureName = u.PictureName
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }


















    }
}