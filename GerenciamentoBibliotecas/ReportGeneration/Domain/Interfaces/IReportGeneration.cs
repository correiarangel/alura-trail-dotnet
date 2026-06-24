namespace ReportGeneration.Domain.Interfaces
{
    /// <summary>
    /// Interface para geração de relatórios. Define as propriedades e métodos necessários para criar um relatório a partir de uma coleção de dados.
    /// </summary>
    public interface IReportGeneration
    {
        /// <summary>
        /// Propriedade que representa a coleção de dados a ser utilizada para gerar o relatório. Cada item da coleção é um dicionário onde a chave é o nome da coluna e o valor é o valor correspondente.  
        /// </summary>
        public List<Dictionary<string, string>> Input { get; set; }

        /// <summary>
        /// Propriedade que representa o título do relatório.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Propriedade que representa a linha de cabeçalho do relatório, geralmente utilizada para descrever as colunas do relatório.
        /// </summary>
        string HeadLine { get; set; }

        /// <summary>
        /// Propriedade que representa a linha de rodapé do relatório, geralmente utilizada para fornecer informações adicionais ou um resumo do relatório.
        /// </summary>
        string FooterLine { get; set; }

        /// <summary>
        /// Método responsável por gerar o relatório a partir dos dados fornecidos na propriedade Input. O    
        /// </summary>
        string GenerateReport();
    }
}