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
    
    public partial class Submit_ShatibiyyahShahed
    {
        public int ID { get; set; }
        public int SubmitID { get; set; }
        public int TableDetailID { get; set; }
        public int BeitID { get; set; }
        public short BeitPart { get; set; }
        public Nullable<int> InsertedDetailID { get; set; }
        public Nullable<int> RejectReason { get; set; }
    
        public virtual SubmitRejectReason SubmitRejectReason { get; set; }
        public virtual UserSubmit UserSubmit { get; set; }
    }
}