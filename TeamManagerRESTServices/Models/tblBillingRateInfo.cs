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
    
    public partial class tblBillingRateInfo
    {
        public int BillingRateId { get; set; }
        public int MemberId { get; set; }
        public decimal Rate { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual tblMemberdetail tblMemberdetail { get; set; }
    }
}
