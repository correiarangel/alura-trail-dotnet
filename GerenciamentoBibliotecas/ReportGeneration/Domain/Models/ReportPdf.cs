using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using ReportGeneration.Domain.Interfaces;

namespace ReportGeneration.Domain.Models;

public class ReportPdf : ReportBase
{
    public ReportPdf(List<Dictionary<string, string>> input) : base(input) { }

    public override string GenerateReport()
    {
        if (Input == null || Input.Count == 0)
            throw new Exception("No data to generate report :(");

        // Caminho absoluto explícito evita surpresas
        var outputPath = Path.Combine(
            AppContext.BaseDirectory, "report.pdf");

        //  Fonte padrão válida do iText7
        var boldFont    = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
        var regularFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

        using var writer   = new PdfWriter(outputPath);
        using var pdf      = new PdfDocument(writer);
        using var document = new iText.Layout.Document(pdf);

        if (!string.IsNullOrWhiteSpace(Title))
        {
            document.Add(new Paragraph(Title)
                .SetFont(boldFont)        //  SetFont em vez de SetFontFamily()
                .SetFontSize(20)
                .SetMarginBottom(10));
        }

        if (!string.IsNullOrWhiteSpace(HeadLine))
        {
            document.Add(new Paragraph(HeadLine)
                .SetFont(regularFont)
                .SetFontSize(16)
                .SetMarginBottom(10));
        }

        var table = new Table(Input.First().Keys.Count)
            .UseAllAvailableWidth(); //  Boa prática: ocupa a largura da página

        foreach (var header in Input.First().Keys)
            table.AddHeaderCell(new Cell().Add(new Paragraph(header).SetFont(boldFont)));

        foreach (var record in Input)
            foreach (var value in record.Values)
                table.AddCell(new Cell().Add(new Paragraph(value).SetFont(regularFont)));

        document.Add(table);

        if (!string.IsNullOrWhiteSpace(FooterLine))
        {
            document.Add(new Paragraph(FooterLine)
                .SetFont(regularFont)
                .SetFontSize(12)
                .SetMarginTop(10));
        }

        return outputPath;
    }
}