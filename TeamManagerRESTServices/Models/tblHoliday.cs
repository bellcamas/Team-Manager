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
    
    public partial class tblHoliday
    {
        public tblHoliday()
        {
            this.tblMemberLeaveDetails = new HashSet<tblMemberLeaveDetail>();
            this.tblRegionsHolidays = new HashSet<tblRegionsHoliday>();
        }
    
        public int HolidayId { get; set; }
        public string HolidayName { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public System.DateTime Date { get; set; }
        public string Day { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public bool isActive { get; set; }
        public bool IsMandatory { get; set; }
    
        public virtual ICollection<tblMemberLeaveDetail> tblMemberLeaveDetails { get; set; }
        public virtual ICollection<tblRegionsHoliday> tblRegionsHolidays { get; set; }
    }
}
