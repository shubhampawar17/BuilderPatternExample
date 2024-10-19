using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternExample.Model;

namespace BuilderPatternExample.Builder
{
//normal interface for creating/building reports
    public interface IReportBuilder
    {
        void SetReportType();
        void SetReportName();
        void SetReportID();
        void CreateNewReport();
        Report GetReport();

        //when we use abstract 
        //protected Report reportObject;
        //public abstract void SetReportType();
        //public abstract void SetReportName();
        //public abstract void SetReportID();

        //public void CreateNewReport()
        //{
        //    reportObject = new Report();
        //}
        //public Report GetReport()
        //{
        //    return reportObject;
        //}
    }
}
