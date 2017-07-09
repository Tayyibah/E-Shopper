using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAD_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Update_Products()
        {
            return View();
        }
        public ActionResult CustomerOrder()
        {
            return View();
        }
        public ActionResult CustomerReviews()
        {
            return View();
        }
        public ActionResult product_details()
        {
            return View();
        }

    }
}