using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoLenguajesMMDS.Data
{
    public class AppointmentData
    {



        public IEnumerable<Select_All_Accepted_Appointment_Result> GetAllAcceptedAppointment(int professorCourseId)
        {

            try
            {

                using (var context = new DBEntities())
                {

                    return context.Select_All_Accepted_Appointment(professorCourseId);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }


        public IEnumerable<Select_All_Hold_Appointment_Result> GetAllHoldAppointment(int professorCourseId)
        {

            try
            {

                using (var context = new DBEntities())
                {

                    return context.Select_All_Hold_Appointment(professorCourseId);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }



        public int AcceptAppointment(int appointmentId)
        {


            try
            {

                using (var context = new DBEntities())
                {
                    return context.Accept_Appointment(appointmentId);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }



        public int RefuseAppointment(int appointmentId)
        {


            try
            {

                using (var context = new DBEntities())
                {
                    return context.Refuse_Appointment(appointmentId);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }



        public int PostAppointment(Appointment appointment, int studentId)
        {
            int result;
            try
            {

                using (var context = new DBEntities())
                {
                    return result = context.Create_Appointment(appointment.Professor_course_id,studentId, appointment.Start_hour, appointment.End_hour, appointment.Day);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;

            }

        }





        public int DeleteAppointment(int appointmentId)
        {
            int result;

            try
            {

                using (var context = new DBEntities())
                {
                    return result = context.Delete_Appointment(appointmentId);
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