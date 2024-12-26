namespace TemplateMethod
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            AnalyzeData();
            FormatReport();
            PrintReport();
        }

        protected void CollectData()
        {
            Console.WriteLine("Collecting data...");
        }

        protected void PrintReport()
        {
            Console.WriteLine("Printing the report...");
        }

        protected abstract void AnalyzeData();
        protected abstract void FormatReport();
    }
}