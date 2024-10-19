using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternExample.Builder;
using BuilderPatternExample.Model;

namespace BuilderPatternExample.Director
{
//report building process
    public class ReportDirector
    {
        public Report MakeReport(IReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportName();
            reportBuilder.SetReportID();
            return reportBuilder.GetReport();
        }
    }
}
