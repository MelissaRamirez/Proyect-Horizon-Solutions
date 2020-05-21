using ProyectoLenguajesMMDS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLenguajesMMDS.Controllers
{
    public class CourseController : Controller
    {

        CourseData courseData = new CourseData();
        // GET: Course
        public JsonResult GetAllCourses()
        {
            return Json(courseData.GetAllCourses(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCourse(int courseId)
        {
            return Json(courseData.GetCourse(courseId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult PostCourse(Course course)
        {
            return Json(courseData.PostCourse(course), JsonRequestBehavior.AllowGet);
        }


        public JsonResult PutCourse(Course course)
        {
            return Json(courseData.PutCourse(course), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteCourse(int courseId)
        {
            return Json(courseData.DeleteCourse(courseId), JsonRequestBehavior.AllowGet);
        }
    }
}