using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample.Model
{
    // The Builder Design Pattern builds a complex object using many simple objects and a step-by-step approach
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportName { get; set; }
        public int ReportId { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine($"Report Type:{ReportType}\n" +
            $"Report Name: {ReportName}\n" +
            $"Report ID:{ReportId}");
        }
    }
}
