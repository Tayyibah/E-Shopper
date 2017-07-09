using DB;
using EAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EAD_Project.Controllers
{
    public class StudentController : ApiController
    {

       // private Shopping_DBEntities db = new Shopping_DBEntities();
        private GradeBookEntities db1 = new GradeBookEntities();
        //public IEnumerable<UsersTable> Get()
        //{
        //    // var db = new DataAccess.DB_A6Entities();
        //    var list = db.UsersTables.ToList();
        //    return list;
        //}
        //public IEnumerable<EAD_Project.Models.UsersTable> Get()
        //{
        //    // var db = new DataAccess.DB_A6Entities();
        //    var list = db.UsersTables.ToList();
        //    return list;
        //}

        public Models.Student Get(int StudentID)
        {
            //var st = db.UsersTables.ToList();
            //var maplist = st.MappingId.ToList();
            DB.Student st = db1.Students.Find(StudentID);
            // DB.Student st = db1.Students.Find(StudentID);
            //var list = st.Mappings.ToList();
            var list = st.Mappings.Where(x=>x.TeacherID==3).ToList();
            // var maplist = st.MappingID.Where(x => x.StudentID == 1)..ToList();
            // var maplist = st.MappingID;
            //var maplist = st.MappingID;
            //var maplist = new List<MappingId>();
            Models.Student result = new Models.Student();
            result.name = st.StudentName;
            result.mapping = new List<MappingsModel>();
            foreach (var item in list)
            {
                result.mapping.Add(new MappingsModel
                {
                    MappingID = item.MappingID,
                    StudentID = item.StudentID,
                    TeacherID = item.TeacherID,
                    DATE = item.DATE
                });
            }
            return result;
        } 
            //    public Models.Student Get(int id)
        //{
        //    //var st = db.UsersTables.ToList();
        //    //var maplist = st.MappingId.ToList();
        //    var st = db1.Students.Find(id);
        //    // var maplist = st.MappingID.Where(x => x.StudentID == 1)..ToList();
        //    var maplist = st.MappingID;
        //    //var maplist = new List<MappingId>();
        //    Models.Student result = new Models.Student();
        //    result.name = st.StudentName;
        //    result.mapping = new List<MappingsModel>();
        //    foreach (var item in maplist)
        //    {
        //        result.mapping.Add(new MappingsModel
        //        {
        //            MappingId = item.MappingId,
        //            // UserId = item.UserId,
        //            ProductID = item.ProductID,
        //            AddToCart = item.AddToCart,
        //            Date = item.Date
        //        });
        //    }

            //public UserMappingClass Get(int id)
            //{
            //    //var st = db.UsersTables.ToList();
            //    //var maplist = st.MappingId.ToList();
            //    var st = db.UsersTables.Find(id);
            //    var maplist = st.MappingId.Where(x=>x.ProductID==1).ToList();
            //    //var maplist = new List<MappingId>();
            //    UserMappingClass result = new UserMappingClass();
            //    result.name = st.Login;
            //    result.mapping = new List<MappingsModel>();
            //    foreach (var item in maplist)
            //    {
            //        result.mapping.Add(new MappingsModel
            //        {
            //            MappingId = item.MappingId,
            //           // UserId = item.UserId,
            //            ProductID = item.ProductID,
            //            AddToCart = item.AddToCart,
            //            Date = item.Date
            //        });
            //    }
            //var st = db.UsersTables.Find(id);
            //var maplist = st.MappingId.ToList();
            ////var maplist = new List<MappingId>();
            //UserMappingClass result = new UserMappingClass();
            //result.name = st.Login;
            //foreach (var item in maplist)
            //{
            //    result.mapping.Add(new MappingsModel
            //    {
            //        MappingId = item,
            //        UserId = item.UserId,
            //        ProductID = item.ProductID,
            //        AddToCart = item.AddToCart,
            //        Date = item.Date
            //    });
            //}
            // var db = new DataAccess.DB_A6Entities();
            //var list = db.UsersTables.ToList();
            //return result;
      //  }
        //public EAD_Project.Models.UsersTable Post(EAD_Project.Models.UsersTable model)
        //{
        //    // var db = new DataAccess.DB_A6Entities();
        //    db.UsersTables.Add(model);
        //    db.SaveChanges();
        //    return model;

        //}
    }
}
