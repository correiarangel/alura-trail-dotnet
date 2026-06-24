using System.Text;
using ReportGeneration.Domain.Interfaces;

namespace ReportGeneration.Domain.Models;

public class ReportCsv : ReportBase
{
    public ReportCsv(List<Dictionary<string, string>> input):base(input){}

    public override string GenerateReport()
    {
        if (Input == null || Input.Count == 0)
        {
            throw new Exception("No data to generate report :(");
        }
        StringBuilder reportBuilder = new StringBuilder();

        if (!string.IsNullOrWhiteSpace(Title))
        {
            reportBuilder.AppendLine(Title);
            reportBuilder.AppendLine("");
        }

        if (!string.IsNullOrWhiteSpace(HeadLine))
        {
            reportBuilder.AppendLine(HeadLine);
            reportBuilder.AppendLine("");
        }

        string header = string.Join(",", Input.First().Keys);

        reportBuilder.AppendLine(header);

        foreach (var row in Input)
        {
            var line = string.Join(";", row.Values);
            reportBuilder.AppendLine(line);
        }
        
        if (!string.IsNullOrWhiteSpace(FooterLine))
        {
            reportBuilder.AppendLine(FooterLine);
            reportBuilder.AppendLine("");
        }
        DateFormat dateFormat = new DateFormat();
        reportBuilder.AppendLine(dateFormat.Format(DateTime.Now.ToString()));

        File.WriteAllText("report.csv", reportBuilder.ToString(),Encoding.UTF8);
        return reportBuilder.ToString();
    }
}
