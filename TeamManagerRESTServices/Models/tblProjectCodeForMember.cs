//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamManagerRESTServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProjectCodeForMember
    {
        public int DefaultTimesheetID { get; set; }
        public Nullable<int> ProjectCodeID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> IsActive { get; set; }
    
        public virtual tblMemberdetail tblMemberdetail { get; set; }
        public virtual tblProjectCode tblProjectCode { get; set; }
    }
}
