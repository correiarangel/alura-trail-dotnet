using ByteBank.Domain.interfece;

namespace ByteBank.Domain.Models;

    public class PdfDocument : IDocumets
    {
        public void Generate(DocParmams docParmams)
        {
            Console.WriteLine("Generating PDF Document...");
        }
    }
