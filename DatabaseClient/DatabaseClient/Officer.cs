//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseClient
{
    using System;
    using System.Collections.Generic;
    
    public partial class Officer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Officer()
        {
            this.PoliceDivisions = new HashSet<PoliceDivision>();
            this.TaskForces = new HashSet<TaskForce>();
        }
    
        public int OfficerId { get; set; }
        public string Name { get; set; }
        public int YearsOnForce { get; set; }
        public int Salary { get; set; }
        public string Description { get; set; }
        public int DivisionId { get; set; }
    
        public virtual PoliceDivision PoliceDivision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PoliceDivision> PoliceDivisions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskForce> TaskForces { get; set; }
    }
}
