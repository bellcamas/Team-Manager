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
    
    public partial class tblApplicationSupport
    {
        public int ApplicatioSupportId { get; set; }
        public int MemberId { get; set; }
        public int ApplicationId { get; set; }
    
        public virtual tblApplication tblApplication { get; set; }
        public virtual tblMemberdetail tblMemberdetail { get; set; }
    }
}
