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
    
    public partial class SPR_DataFeed
    {
        public long ReportID { get; set; }
        public string Source { get; set; }
        public string StatementText { get; set; }
        public Nullable<long> LiveReportID { get; set; }
    
        public virtual SPR_Reports SPR_Reports { get; set; }
    }
}
