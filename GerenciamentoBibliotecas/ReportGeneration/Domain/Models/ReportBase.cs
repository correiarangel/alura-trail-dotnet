using ReportGeneration.Domain.Interfaces;

namespace ReportGeneration.Domain.Models
{
    public abstract class ReportBase : IReportGeneration
    {
        public ReportBase(List<Dictionary<string, string>> input)
        {
            Input = input;
        }

        public ReportBase(List<Dictionary<string, string>> input, string? title, string? headLine, string? footerLine)
        {
            Input = input;
            Title = title;
            HeadLine = headLine;
            FooterLine = footerLine;
        }

        public List<Dictionary<string, string>> Input { get; set; }
        public string? Title { get; set; }
        public string? HeadLine { get; set; }
        public string? FooterLine { get; set; }

        /// <summary>
        /// Metodo abstrato que gera o relatorio
        /// </summary>
        /// <returns></returns>
        public abstract string GenerateReport();

    }
}