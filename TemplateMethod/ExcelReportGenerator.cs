namespace TemplateMethod
{
    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void AnalyzeData()
        {
            Console.WriteLine("Analyzing data for Excel report...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting report in Excel format...");
        }
    }
}