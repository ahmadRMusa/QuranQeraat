//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSubmit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserSubmit()
        {
            this.Submit_DorrahShahed = new HashSet<Submit_DorrahShahed>();
            this.Submit_Khlaf = new HashSet<Submit_Khlaf>();
            this.Submit_KhlafGroup = new HashSet<Submit_KhlafGroup>();
            this.Submit_MawdeaKhlaf = new HashSet<Submit_MawdeaKhlaf>();
            this.Submit_MawdeaKhlafDetail = new HashSet<Submit_MawdeaKhlafDetail>();
            this.Submit_ShatibiyyahShahed = new HashSet<Submit_ShatibiyyahShahed>();
        }
    
        public int ID { get; set; }
        public int UserId { get; set; }
        public System.DateTime SubmitTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Submit_DorrahShahed> Submit_DorrahShahed { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Submit_Khlaf> Submit_Khlaf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Submit_KhlafGroup> Submit_KhlafGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Submit_MawdeaKhlaf> Submit_MawdeaKhlaf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Submit_MawdeaKhlafDetail> Submit_MawdeaKhlafDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Submit_ShatibiyyahShahed> Submit_ShatibiyyahShahed { get; set; }
        public virtual User User { get; set; }
    }
}