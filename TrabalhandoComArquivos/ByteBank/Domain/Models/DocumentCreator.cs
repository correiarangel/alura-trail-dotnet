using ByteBank.Domain.interfece;

namespace ByteBank.Domain.Models;
public abstract class DocumentCreator
{
    public abstract IDocumets CreateDocument();
    public void GenerateDocument()
    {
        var document = CreateDocument();
        document.Generate(new DocParmams("teste.txt", "teste"));
    }
}