using ReportGeneration.Domain.Interfaces;

namespace ReportGeneration.Domain.Models
{
    internal class DateFormat : IDataFormater
    {
        public string Format(string input)
        {
            if (DateTime.TryParse(input, out DateTime date))
            {
                return date.ToString("dd/MM/yyyy");
            }
            return input;
        }
    }
}