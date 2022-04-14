using CreationalDesignPattern.Builder.BuilderDesignPattern.EX1.Builder;

namespace CreationalDesignPattern.Builder.BuilderDesignPattern.EX1
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
}
