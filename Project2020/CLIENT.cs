//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2020
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT()
        {
            this.BOOKINGs = new HashSet<BOOKING>();
            this.TRANSACTIONs = new HashSet<TRANSACTION>();
            this.REGISTERs = new HashSet<REGISTER>();
        }
    
        public string Client_ID { get; set; }
        public string Client_Name { get; set; }
        public string Client_LastName { get; set; }
        public string Client_Email { get; set; }
        public string Client_PhoneNumber { get; set; }
        public Nullable<System.DateTime> Client_Date_Joined { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKING> BOOKINGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACTION> TRANSACTIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTER> REGISTERs { get; set; }
    }
}
