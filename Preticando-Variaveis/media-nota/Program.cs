internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n Calcula média de notas: USE NUMEROS !\n");

        float nota1 = GetInput("Digite a nota 1:");
        float nota2 = GetInput("Digite a nota 2:");
        float nota3 = GetInput("Digite a nota 3:");
        CalcularMedia(nota1, nota1, nota2);
    }

    static float GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();

            string inputFilter = new([.. input.Where(c => char.IsDigit(c) || c == '.' || c == ',')]);

            if (float.TryParse(inputFilter, out float real))
            {
                return real;
            }
            Console.WriteLine("Valor invalido !....");

        }
    }
    static void CalcularMedia(float nota1, float nota2, float nota3 )
    {
        var media = (nota1+nota2+nota3) / 3;
        Console.WriteLine($"Media:{media} de notas.");
    }

}