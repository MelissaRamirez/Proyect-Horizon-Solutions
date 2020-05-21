using ProyectoLenguajesMMDS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLenguajesMMDS.Controllers
{
    public class PersonController : Controller
    {

        PersonData personData = new PersonData();
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        JsonResult DesactivatePerson(int id) 
        {
            return Json(personData.DesactivatePerson(id), JsonRequestBehavior.AllowGet);
        }

        JsonResult ActivatePerson(int id)
        {
            return Json(personData.ActivatePerson(id), JsonRequestBehavior.AllowGet);
        }

        JsonResult GetProvince()
        {
            return Json(personData.GetProvince(), JsonRequestBehavior.AllowGet);
        }


        JsonResult GetCanton(int idProvince)
        {
            return Json(personData.GetCanton(idProvince), JsonRequestBehavior.AllowGet);
        }

        JsonResult GetDistric(Distric district)
        {
            return Json(personData.GetDistric(district.Province_id, district.Canton_id), JsonRequestBehavior.AllowGet);
        }

    }
}