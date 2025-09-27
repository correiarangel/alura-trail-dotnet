
internal partial class Program
{
    static int vidas = 5;
     static  int secretNumber = 0;
    private static void Main(string[] args)
    {
        Random secretrRandomNumber = new Random();
        secretNumber = secretrRandomNumber.Next(0, 100);
        Console.WriteLine("\n JOGO DE ADIVINHAÇÂO,\n");
        Console.WriteLine("Descubar o numero secreto de 0 a 100 e ganhe o jogo,se não adivinhar peder uma vida. \n Você começa com 10 vidas se 0 perde .\n");
        while (true)
        {
            int secretInmput = GetInput($" {secretNumber} Qual é o numero secreto:");
            int rvidas = QualEoNumeroSecreto(secretNumber, secretInmput);

            if (!TemVida(rvidas)) break;
        }
    }

    private static bool TemVida(int rvidas)
    {
        if (vidas == 0)
        {
            Console.WriteLine($"Fim de Jogo você Perdeu :( \n Numero de vidas: {vidas} \n Numero secreto: {secretNumber}");
            return false;
        }
        if (vidas >= 10)
        {
            Console.WriteLine($"Fim de Jogo você venceu ;) \n Numero de vidas: {vidas} \n Numero secreto: {secretNumber}");
            return false;
        }
        Console.WriteLine($"Continue Jogando ......");

        return true;
    }

    private static int QualEoNumeroSecreto(int secretNumber, int secretInmput)
    {

        if (secretInmput == secretNumber)
        {
            Console.WriteLine($"Você ganhou uma vida\n Numero de vidas; {vidas}");
            return vidas = 10;
        }
        else
        {
            Console.WriteLine($"Você perdeu uma vida\n Numero de vidas; {vidas}");
            return vidas -=1;
        }

    }

    static int GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();
            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                return real;
            }
            Console.WriteLine("Valor invalido !....$##@*(&@) ;(");
        }
    }

}
