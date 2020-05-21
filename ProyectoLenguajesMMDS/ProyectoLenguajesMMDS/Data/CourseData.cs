using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoLenguajesMMDS.Data
{
    public class CourseData
    {


        public IEnumerable<Select_Course_Result> GetAllCourses()
        {

            try { 

            using (var context = new DBEntities())
              {

                return context.Select_Course();
              }

            }catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }


        public IEnumerable<Select_All_Course_From_Professor_Result> GetAllCoursesByProfessor(int courseId)
        {

            try
            {

                using (var context = new DBEntities())
                {

                    return context.Select_All_Course_From_Professor(courseId);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }



        public Select_Course_By_Id_Result GetCourse(int courseId)
        {
          

            try
            {

                using (var context = new DBEntities())
                {
                    return context.Select_Course_By_Id(courseId).FirstOrDefault();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }


        public int PostCourse(Course course)
        {
            int result;
            try { 

            using (var context = new DBEntities())
            {
                return result = context.Insert_Course(course.Credits, course.Code, course.Name, course.Term);
            }
             
            }catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }


        public int PutCourse(Course course)
        {
            int result;

            try { 

            using (var context = new DBEntities())
            {
                return result = context.Update_Course(course.Course_id,course.Credits, course.Code, course.Name, course.Term);
            }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }



        public int DeleteCourse(int courseId)
        {
            int result;

            try
            {

                using (var context = new DBEntities())
                {
                    return result = context.Delete_Course(courseId);
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