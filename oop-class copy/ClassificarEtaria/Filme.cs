class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public Filme(string titulo, int classificacaoEtaria)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacaoEtaria;
    }

    public bool Assistir(int idadeUsuario)
    {
        return idadeUsuario >= ClassificacaoEtaria;
    }
    public void ExibirResultado(int idadeUsuario)
    {
        if (Assistir(idadeUsuario))
        {
            Console.WriteLine("Usuário com " + idadeUsuario + " anos pode assistir ao filme " + Titulo + ".");
        }
        else
        {
            Console.WriteLine("Usuário com " + idadeUsuario + " anos não pode assistir ao filme " + Titulo + ".");
        }
    }
}