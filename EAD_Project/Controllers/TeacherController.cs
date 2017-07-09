using DB;
using EAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAD_Project.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            IEnumerable<Teacher> list = db1.Teachers.ToList();
            return View(list);
        }
        private GradeBookEntities db1 = new GradeBookEntities();

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeacherModel t)
        {
            
            if (ModelState.IsValid)
            {
                Teacher t1 = new Teacher();

                t1.TeacherName = t.TeacherName;
                t1.tEACHERsUBJECT = t.tEACHERsUBJECT;
                db1.Teachers.Add(t1);
                db1.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}