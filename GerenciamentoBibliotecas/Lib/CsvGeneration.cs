using ReportGeneration.Domain.Models;

internal class CsvGenerator : ReportCsv
{
    public CsvGenerator(List<Dictionary<string, string>> input) : base(input)
    {

    }
    public string GenerateReportCsv(string fileName)
    {
        GenerateReport();
        File.Move("report.csv", fileName);
        return Path.GetFullPath(fileName);
    }
}
