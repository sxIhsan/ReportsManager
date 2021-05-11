using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportsManager.ViewModels
{
    public class ReportViewModel
    {
        [Key]
        public long ID { get; set; }

        [DisplayName("Report Name"), Required]
        public string Name { get; set; }

        [DisplayName("Data Source Type"), Required]
        public string Source { get; set; }//dropdown statement,livereport

        [DataType(DataType.MultilineText)]
        [DisplayName("SQL Statement")]
        public string StatementText { get; set; }//allow input if statement
        public Nullable<long> LiveReportID { get; set; }//allow input if livereport
        public string SettingText { get; set; }
        public string ThumbnailImage { get; set; }
    }
}