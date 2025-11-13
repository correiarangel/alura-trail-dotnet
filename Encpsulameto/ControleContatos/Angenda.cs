class Agenda(string proprietario)
{
    public string Proprietario { get; set; } = proprietario;

    private readonly List<Contato> contatos = new List<Contato>();
    public bool AdicionarContato(Contato contato)
    {
        foreach (var c in contatos)
        {
            if (c.Nome == contato.Nome)
            {
                Console.WriteLine($"Contato com esse {contato.Nome} nome já está na agenda.");
                return false;
            }
        }
        contatos.Add(contato);
        return true;
    }
    public void ListarContatos()
    {
        Console.WriteLine($"Contatos de {Proprietario}:");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
        }
    }
    public int QuantidadeContatos
    {
        get { return contatos.Count; }
    }
}