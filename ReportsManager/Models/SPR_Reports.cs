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
    
    public partial class SPR_Reports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPR_Reports()
        {
            this.SPR_Tasks = new HashSet<SPR_Tasks>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
    
        public virtual SPR_DataFeed SPR_DataFeed { get; set; }
        public virtual SPR_ReportAssets SPR_ReportAssets { get; set; }
        public virtual SPR_ReportSettings SPR_ReportSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPR_Tasks> SPR_Tasks { get; set; }
    }
}
