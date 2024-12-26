using TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generating PDF Report:");
        ReportGenerator pdfReport = new PdfReportGenerator();
        pdfReport.GenerateReport();

        Console.WriteLine("\nGenerating Excel Report:");
        ReportGenerator excelReport = new ExcelReportGenerator();
        excelReport.GenerateReport();
    }
}