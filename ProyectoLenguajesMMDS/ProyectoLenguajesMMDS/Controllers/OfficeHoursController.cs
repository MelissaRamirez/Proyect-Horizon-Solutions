using ProyectoLenguajesMMDS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;


namespace ProyectoLenguajesMMDS.Controllers
{
    public class OfficeHoursController: Controller
    {


        OfficeHoursData officeHoursData = new OfficeHoursData();
        // GET: Course
        public JsonResult GetAllOfficeHoursByCourse(int professorCourseId)
        {
            return Json(officeHoursData.GetAllOfficeHoursByCourse(professorCourseId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOfficeHour(int officeHourId)
        {
            return Json(officeHoursData.GetOfficeHour(officeHourId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult PostOfficeHour(Office_Hours officeHour)
        {
            return Json(officeHoursData.PostOfficeHour(officeHour), JsonRequestBehavior.AllowGet);
        }


        public JsonResult PutCourse(Office_Hours officeHour)
        {
            return Json(officeHoursData.PutOfficeHour(officeHour), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteCourse(int officeHourId)
        {
            return Json(officeHoursData.DeleteOfficeHour(officeHourId), JsonRequestBehavior.AllowGet);
        }
    }
}
