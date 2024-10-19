using BuilderPatternExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample.Builder
{
    public class HtmlReport : IReportBuilder
    {
        private Report _reportObject;
        public void SetReportType()
        {
            _reportObject.ReportType = "HTML";
        }
        public void SetReportName()
        {
            _reportObject.ReportName = "Design Principle";
        }
        public void SetReportID()
        {
            _reportObject.ReportId = 102;
        }
        public void CreateNewReport()
        {
            _reportObject = new Report();
        }
        public Report GetReport()
        {
            return _reportObject;
        }
    }
}
