using System.Collections;
using IntroColecoes.Models;

class DaysOfTheWeek : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        //return new MyEnumerator();
        yield return "Domingo";
        yield return "Segunda";
        yield return "Terça";
        yield return "Quarta";
        yield return "Quinta";
        yield return "Sexta";
        yield return "Sábado";
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<int> EvenNumbers(int limite)
    {
        var numbers = new List<int>();
        for (var i = 0; i < limite; i++)
        {
            Console.WriteLine($"Processando elemento {i}...");
            numbers.Add(i * 2);
        }
        return numbers;
    }

    public IEnumerable<int> YeldEvenNumbers(int limiter)
    {
        var i = 0;
        while (true)
        {
            Console.WriteLine($"Processando elemento {i}...");
            yield return i * 2;
            if (i > limiter) yield break;
            i++;
        }
    }

}