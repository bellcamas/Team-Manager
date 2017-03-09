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
    
    public partial class tblMemberdetail
    {
        public tblMemberdetail()
        {
            this.tblApplicationSupports = new HashSet<tblApplicationSupport>();
            this.tblBillingRateInfoes = new HashSet<tblBillingRateInfo>();
            this.tblMemberAccesses = new HashSet<tblMemberAccess>();
            this.tblMemberLeaveDetails = new HashSet<tblMemberLeaveDetail>();
            this.tblPagerPlans = new HashSet<tblPagerPlan>();
            this.tblProjectCodeForMembers = new HashSet<tblProjectCodeForMember>();
            this.tblTimeSheetBookings = new HashSet<tblTimeSheetBooking>();
        }
    
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string PsaId { get; set; }
        public string CgiLanId { get; set; }
        public string BellNtId { get; set; }
        public string BellPein { get; set; }
        public string EmailId { get; set; }
        public int MangerId { get; set; }
        public string LaptopNumber { get; set; }
        public string MobileNumber { get; set; }
        public string MsnId { get; set; }
        public System.DateTime CgiJoinDate { get; set; }
        public System.DateTime ProjectJoinDate { get; set; }
        public bool IsReleasedFromProject { get; set; }
        public Nullable<System.DateTime> ProjectRelivingDate { get; set; }
        public bool InCgi { get; set; }
        public Nullable<System.DateTime> CgiRelievingDate { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public bool IsResourceManager { get; set; }
        public bool IsSelfManager { get; set; }
    
        public virtual ICollection<tblApplicationSupport> tblApplicationSupports { get; set; }
        public virtual ICollection<tblBillingRateInfo> tblBillingRateInfoes { get; set; }
        public virtual ICollection<tblMemberAccess> tblMemberAccesses { get; set; }
        public virtual ICollection<tblMemberLeaveDetail> tblMemberLeaveDetails { get; set; }
        public virtual ICollection<tblPagerPlan> tblPagerPlans { get; set; }
        public virtual ICollection<tblProjectCodeForMember> tblProjectCodeForMembers { get; set; }
        public virtual ICollection<tblTimeSheetBooking> tblTimeSheetBookings { get; set; }
    }
}