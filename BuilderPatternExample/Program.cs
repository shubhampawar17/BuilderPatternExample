using BuilderPatternExample.Builder;
using BuilderPatternExample.Director;
using BuilderPatternExample.Model;

namespace BuilderPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportDirector reportDirector = new ReportDirector();
            PdfReport pdf = new PdfReport();
            Report pdf1 = reportDirector.MakeReport(pdf);
            pdf1.DisplayReport();
            Console.WriteLine("#########################");
            HtmlReport html = new HtmlReport();
            Report html1= reportDirector.MakeReport(html);
            html1.DisplayReport();
        }
    }
}
