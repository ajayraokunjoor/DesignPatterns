using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client Code
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            //Construct and Display Reports
            PDFReport pDFReport = new PDFReport();
            report = reportDirector.MakeReport(pDFReport);
            report.DisplayReport();

            System.Console.WriteLine("--------------------------");

            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            System.Console.ReadKey();

        }
    }
}
