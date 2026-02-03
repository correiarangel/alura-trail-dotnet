namespace ByteBank.Domain.interfece;
public interface IDocumets
{
    public void Generate(DocParmams docParmams);
}

public class DocParmams(string path, string content)
{
    public string Path { get; set; } = path;
    public string Content { get; set; } = content;
}