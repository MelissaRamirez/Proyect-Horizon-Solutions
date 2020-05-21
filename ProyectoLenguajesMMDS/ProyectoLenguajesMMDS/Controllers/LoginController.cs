using ProyectoLenguajesMMDS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLenguajesMMDS.Controllers
{
    public class LoginController : Controller
    {
        LoginData loginData = new LoginData();
      
        public JsonResult ValidateUserToLogin(string username, string password)
        {
            SelectLogin_Result result = loginData.Login(username,password);

            if (result.Role == "Professor")
            {

                return Json(loginData.GetProfessor(result.Person_id), JsonRequestBehavior.AllowGet);
               
            }
            else if (result.Role == "Student")
            {

                return Json(loginData.GetStudent(result.Person_id), JsonRequestBehavior.AllowGet);

            }
          


            return null;
            
        }

    }
}