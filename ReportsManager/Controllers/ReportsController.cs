using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReportsManager.Models;
using ReportsManager.ViewModels;

namespace ReportsManager.Controllers
{
    public class ReportsController : Controller
    {
        private csdbEntities db = new csdbEntities();

        // GET: SPR_Reports
        public ActionResult Index()
        {
            //var sPR_Reports = db.SPR_Reports.Include(s => s.SPR_DataFeed).Include(s => s.SPR_ReportSettings);
            
            //List<SPR_Reports> reports = sPR_Reports.ToList();
            //reports.Sort((x, y) => x.Name.CompareTo(y.Name));

            //var serialized = Newtonsoft.Json.JsonConvert.SerializeObject(reports, Formatting.Indented,
            //new JsonSerializerSettings
            //{
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //});
            string currDir = AppContext.BaseDirectory;
            string mockDataPath = Path.Combine(currDir, @"Resource\mockIndex.txt");
            //System.IO.File.WriteAllText(mockDataPath, serialized);
            string mockData = System.IO.File.ReadAllText(mockDataPath);
            List<SPR_Reports> deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SPR_Reports>>(mockData);
            return View(deserialized);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
