//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportsManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SPR_Trigger_Monthly
    {
        public long ID { get; set; }
        public long TaskID { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public bool IsModeDays { get; set; }
        public bool IsModeOn { get; set; }
        public string MonthsOfYear { get; set; }
        public string DaysOfMonth { get; set; }
        public string TargetedWeek { get; set; }
        public string DaysOfTargetedWeek { get; set; }
    
        public virtual SPR_Tasks SPR_Tasks { get; set; }
    }
}