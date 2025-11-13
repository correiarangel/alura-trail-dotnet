class Estudante(string nome)
{
    public string Nome { get; set; } = nome;

    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public double Media()
    {
        return (Nota1 + Nota2 + Nota3) / 3.0;
    }

    public string Situacao()
    {
        double media = Media();
        if (media >= 6.0)
        {
            return "Aprovado";
        }
        else if (media >= 4.0)
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }
}