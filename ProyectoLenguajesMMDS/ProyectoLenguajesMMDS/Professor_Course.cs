//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoLenguajesMMDS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professor_Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professor_Course()
        {
            this.Appointment = new HashSet<Appointment>();
            this.Office_Hours = new HashSet<Office_Hours>();
        }
    
        public int Professor_course_id { get; set; }
        public int Course_id { get; set; }
        public int Professor_id { get; set; }
        public Nullable<int> Created_by { get; set; }
        public Nullable<System.DateTime> Create_at { get; set; }
        public Nullable<int> Updated_by { get; set; }
        public Nullable<System.DateTime> Updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Office_Hours> Office_Hours { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
        public virtual Professor Professor { get; set; }
    }
}