namespace CreationalDesignPattern.Builder.BuilderDesignPattern.EX1
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportContent { get; set; }
        public string ReportFooter { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine("Report Type : {0}",ReportType);
            Console.WriteLine("Report Header : {0}", ReportHeader);
            Console.WriteLine("Report Content : {0}", ReportContent);
            Console.WriteLine("Report Footer : {0}", ReportFooter);
        }
    }
}
