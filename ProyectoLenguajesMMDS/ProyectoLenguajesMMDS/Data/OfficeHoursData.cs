using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoLenguajesMMDS.Data
{
    public class OfficeHoursData
    {




        public IEnumerable<Select_Office_Hours_By_Course_Result> GetAllOfficeHoursByCourse(int professorCourseId)
        {

            try
            {

                using (var context = new DBEntities())
                {

                    return context.Select_Office_Hours_By_Course(professorCourseId);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }





        public Select_Office_Hours_By_Id_Result GetOfficeHour(int officeHourId)
        {


            try
            {

                using (var context = new DBEntities())
                {
                    return context.Select_Office_Hours_By_Id(officeHourId).FirstOrDefault();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }


        public int PostOfficeHour(Office_Hours officeHours)
        {
            int result;
            try
            {

                using (var context = new DBEntities())
                {
                    return result = context.Insert_Office_Hours(officeHours.Start_hour,officeHours.End_hour,officeHours.Day,officeHours.Professor_course_id);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }


        public int PutOfficeHour(Office_Hours officeHours)
        {
            int result;

            try
            {

                using (var context = new DBEntities())
                {
                    return result = context.Update_Office_Hours(officeHours.Office_hours_id,officeHours.Start_hour, officeHours.End_hour, officeHours.Day, officeHours.Professor_course_id);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }



        public int DeleteOfficeHour(int officeHourId)
        {
            int result;

            try
            {

                using (var context = new DBEntities())
                {
                    return result = context.Delete_Office_Hours(officeHourId);
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