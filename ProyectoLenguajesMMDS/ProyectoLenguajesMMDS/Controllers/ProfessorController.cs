using ProyectoLenguajesMMDS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLenguajesMMDS.Controllers
{
    public class ProfessorController : Controller
    {

        ProfessorData professorData = new ProfessorData();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Register(Professor professor)
        {
            return Json(professorData.Register(professor), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListAll()
        {
            return Json(professorData.ListAll(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllProfessorsOff()
        {
            return Json(professorData.GetAllProfessorsOff(), JsonRequestBehavior.AllowGet);
        }
       

        public JsonResult GetById(int id)
        {
            return Json(professorData.GetProfessorById(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetByCourse(int courseId)
        {
            return Json(professorData.GetByCourse(courseId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult InsertProfessorCourse(int professorId, int courseId)
        {
            return Json(professorData.InsertCourseProfessor(professorId, courseId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateProfessorCourse(int professorCourse, int professorId, int courseId)
        {
            return Json(professorData.UpdatetCourseProfessor(professorCourse, professorId, courseId), JsonRequestBehavior.AllowGet);
        }

    }
}