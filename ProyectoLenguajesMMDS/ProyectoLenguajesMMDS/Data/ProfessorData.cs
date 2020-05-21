using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace ProyectoLenguajesMMDS.Data
{
    public class ProfessorData
    {
        public int Register(Professor professor)
        {
            Person person = professor.Person;

            int returnResult = 0;

            using (var context = new DBEntities())
            {
                DateTime today = DateTime.Today;
                returnResult = context.SpInsert_Update_Professor(0, person.Email, person.Password,
                                                 person.Name, person.Last_name, person.Interests, person.Profile_pic, true,
                                                 person.Distric_id, person.Canton_id, person.Province_id, 0, today, 0, today,
                                                 person.Role, professor.Especiality, "Insert");
            }

            return returnResult;
        }

        public IEnumerable<Get_Professors_Result> ListAll()
        {


            using (var context = new DBEntities())
            {
                DateTime today = DateTime.Today;
                return context.Get_Professors();
            }
        }

        public IEnumerable<Get_Professor_By_Id_Result> GetProfessorById(int id)
        {
            using (var context = new DBEntities())
            {
                DateTime today = DateTime.Today;
                return context.Get_Professor_By_Id(id);
            }
        }

        public int Update(Professor professor)
        {
            Person person = professor.Person;


            using (var context = new DBEntities())
            {
                DateTime today = DateTime.Today;
                return context.SpInsert_Update_Professor(0, person.Email, person.Password,
                                                  person.Name, person.Last_name, person.Interests, person.Profile_pic, true,
                                                  person.Distric_id, person.Canton_id, person.Province_id, 0, today, 0, today,
                                                  person.Role, professor.Especiality, "Update");
            }
        }

        public IEnumerable<Select_Professors_By_Course_Result> GetByCourse(int courseId)
        {
            using (var context = new DBEntities())
            {
               return  context.Select_Professors_By_Course(courseId);
            }

            }


        public IEnumerable<Get_Professors_Off_Result> GetAllProfessorsOff()
        {


            using (var context = new DBEntities())
            {

                return context.Get_Professors_Off();
            }
        }

        public int InsertCourseProfessor(int professorId, int courseId) 
        {
            using (var context = new DBEntities()) 
            {
                return context.Insert_Update_Professor_To_Course(0, professorId, courseId, professorId, 0, "Insert");
            }
        }

        public int UpdatetCourseProfessor(int professorCourseId, int professorId, int courseId)
        {
            using (var context = new DBEntities())
            {
                return context.Insert_Update_Professor_To_Course(professorCourseId, professorId, courseId, 0, professorId, "Update");
            }
        }
    }

 
}