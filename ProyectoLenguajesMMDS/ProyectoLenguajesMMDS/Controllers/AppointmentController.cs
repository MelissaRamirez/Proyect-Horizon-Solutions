using ProyectoLenguajesMMDS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLenguajesMMDS.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        AppointmentData appointmentData = new AppointmentData();
        // GET: Course
        public JsonResult GetAllAcceptedAppoinment(int professorCourseId)
        {
            return Json(appointmentData.GetAllAcceptedAppointment(professorCourseId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllHoldAppoinment(int professorCourseId)
        {
            return Json(appointmentData.GetAllHoldAppointment(professorCourseId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult AcceptAppointment(int appoinmentId)
        {
            return Json(appointmentData.AcceptAppointment(appoinmentId), JsonRequestBehavior.AllowGet);
        }


        public JsonResult RefuseAppointment(int appoinmentId)
        {
            return Json(appointmentData.RefuseAppointment(appoinmentId), JsonRequestBehavior.AllowGet);
        }



        public JsonResult PostAppointment(Appointment appointment, int studentId)
        {
            return Json(appointmentData.PostAppointment(appointment,studentId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteCourse(int appointmentId)
        {
            return Json(appointmentData.DeleteAppointment(appointmentId), JsonRequestBehavior.AllowGet);
        }
    }
}
