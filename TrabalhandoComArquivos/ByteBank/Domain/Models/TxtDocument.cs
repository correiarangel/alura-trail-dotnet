using ByteBank.Domain.interfece;

namespace ByteBank.Domain.Models;

class TxtDocument : IDocumets
{
    public void Generate(DocParmams docParmams)
    {
        // "456,65465,456.0,Pedro"
        using (var fluxoDeArquivo = new FileStream(docParmams.Path, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write(docParmams.Content);
        }
    }
}