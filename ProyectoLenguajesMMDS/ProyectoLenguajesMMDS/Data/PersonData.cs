using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace ProyectoLenguajesMMDS.Data
{
    public class PersonData
    {

        public IEnumerable<Get_Province_Result> GetProvince()
        {
            using (var context = new DBEntities())
            {
                return context.Get_Province();
            }
        }

        public IEnumerable<Get_Canton_By_Province_Result> GetCanton(int idProvince)
        {
            using (var context = new DBEntities()) 
            {
                return context.Get_Canton_By_Province(idProvince);
            }
        }

        public IEnumerable<Get_District_By_Province_Canton_Result> GetDistric(int idProvince, int idCanton)
        {
            using (var context = new DBEntities())
            {
                return context.Get_District_By_Province_Canton(idProvince, idCanton);
            }
        }

        public int DesactivatePerson(int id)
        {

            using (var context = new DBEntities())
            {
                DateTime today = DateTime.Today;
                return context.Desactivate_Person_Account(id, id);
            }
        }

        public int ActivatePerson(int id)
        {

            using (var context = new DBEntities())
            {
                DateTime today = DateTime.Today;
                return context.Reactivate_Person_Account(id, id);
            }
        }

    }
}