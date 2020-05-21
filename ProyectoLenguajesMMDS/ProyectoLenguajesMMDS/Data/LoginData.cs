
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProyectoLenguajesMMDS.Data
{
    public class LoginData
    {



        public  SelectLogin_Result Login(string Email, string Password)
        {

            SelectLogin_Result loginResult = new SelectLogin_Result();
            try
            {

            using (var context =  new DBEntities())
            {
                    return loginResult = context.SelectLogin(Email,Password).FirstOrDefault();
            }
            }
            catch (SqlException ex)
            {
               Console.WriteLine(ex);
               throw;

            }
    
        }



        public Get_Professor_By_Id_Result GetProfessor(int professor_id)
        {
            Get_Professor_By_Id_Result professor = new Get_Professor_By_Id_Result();
            try
            {

                using (var context = new DBEntities())
                {
                    return context.Get_Professor_By_Id(professor_id).FirstOrDefault();
                  
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }




        public Get_Students_By_id_Result GetStudent(int student_id)
        {
            Get_Students_By_id_Result student = new Get_Students_By_id_Result();
            try
            {

                using (var context = new DBEntities())
                {
                    return context.Get_Students_By_id(student_id).FirstOrDefault();

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                 throw;
            }

        }

    }

    }