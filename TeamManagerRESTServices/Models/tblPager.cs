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
    
    public partial class tblPager
    {
        public tblPager()
        {
            this.tblPagerPlans = new HashSet<tblPagerPlan>();
        }
    
        public int PagerId { get; set; }
        public int ApplicationId { get; set; }
        public string PagerNumber { get; set; }
        public string PagerEmailId { get; set; }
    
        public virtual tblApplication tblApplication { get; set; }
        public virtual ICollection<tblPagerPlan> tblPagerPlans { get; set; }
    }
}
