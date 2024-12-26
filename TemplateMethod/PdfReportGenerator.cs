namespace TemplateMethod
{
    public class PdfReportGenerator : ReportGenerator
    {
        protected override void AnalyzeData()
        {
            Console.WriteLine("Analyzing data for PDF report...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting report in PDF format...");
        }
    }
}