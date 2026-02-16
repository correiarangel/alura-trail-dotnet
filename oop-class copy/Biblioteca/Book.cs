class Book()
{
    public string? Title { get; set; }=string.Empty; 
    public string? Author { get; set; }=string.Empty;

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}";
    }
}