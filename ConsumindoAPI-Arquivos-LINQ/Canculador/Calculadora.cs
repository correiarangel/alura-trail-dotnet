class Calculadora
{
    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("Selecione a operação desejada:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Potência");
        Console.WriteLine("6 - Raiz Quadrada");
        Console.WriteLine("7 - Porcentagem");

        try
        {
            Console.Write("\nDigite a opção desejada: ");
            var opcao = Console.ReadLine();
            input(opcao);
        }
        catch (FormatException err)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número correspondente à opção.");
            throw new Exception("\nErro na leitura da entrada; ", err);
        }


    }

    private void input(string opcao)
    {
        switch (opcao)
        {
            case "1":
                Somar();
                break;
            case "2":
                Subtrair();
                break;
            case "3":
                Multiplicar();
                break;
            case "4":
                Dividir();
                break;
            case "5":
                Potencia();
                break;
            case "6":
                RaizQuadrada();
                break;
            case "7":
                Porcentagem();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    public void Somar()
    {
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());
        int resultado = a + b;
        Console.WriteLine($"O resultado da soma entre {a} e {b} é {resultado}");
    }

    public void Subtrair()
    {
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());
        int resultado = a - b;
        Console.WriteLine($"O resultado da subtração entre {a} e {b} é {resultado}");
    }

    public void Multiplicar()
    {
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());
        int resultado = a * b;
        Console.WriteLine($"O resultado da multiplicação entre {a} e {b} é {resultado}");
    }

    public void Dividir()
    {
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
            int resultado = a / b;
            Console.WriteLine($"O resultado da divisão entre {a} e {b} é {resultado}");
        }
    }

    public void Potencia()
    {
        Console.Write("Digite a base: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Digite o expoente: ");
        int b = int.Parse(Console.ReadLine());
        {
            double resultado = Math.Pow(a, b);
            Console.WriteLine($"O resultado de {a} elevado a {b} é {resultado}");
        }
    }

    public void RaizQuadrada()
    {
        Console.Write("Digite o número: ");
        int a = int.Parse(Console.ReadLine());
        {
            if (a < 0)
            {
                Console.WriteLine("Erro: Raiz quadrada de número negativo não é permitida.");
                return;
            }
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"A raiz quadrada de {a} é {resultado}");
        }
    }

    public void Porcentagem()
    {
        Console.Write("Digite o valor total: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Digite a porcentagem (%): ");
        double b = double.Parse(Console.ReadLine());
        {
            double resultado = (a * b) / 100.0;
            Console.WriteLine($"{b}% de {a} é {resultado}");
        }
    }
}