
using System.Collections;

Console.WriteLine("\n*** Introodução a coleções e LINQ ***\n");

var daysOfTheWeek = new ArrayList(){
    "Segunda",
    "Terça",
    "Quarta",
    "Quinta",
    "Sexta",
    "Sábado",
    "Domingo"
};
Interando (daysOfTheWeek);

var days = new DaysOfTheWeek();

//var itens =  days.YeldEvenNumbers(10);

var itens = days.EvenNumbers(10);
foreach (var item in itens)
{
    Console.WriteLine(item);
}

/*
var evens = days.EvenNumbers(1000000000);

var contador = 0;
foreach (var even in evens)
{
    contador++;
    Console.WriteLine(even);
    if (contador > 5) break;
}*/
/*
foreach(var even in evens)
{
    Console.WriteLine(even);
}*/


Console.WriteLine("\n*** Fim do programa ***\n");

void Interando (ArrayList arrayList)
{
    Console.WriteLine("\nInterando ArryList\n");
    foreach (var item in arrayList)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("\nFim de InterançãoArryList\n");
}

