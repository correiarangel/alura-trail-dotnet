
List<string> msgs = new List<string>{"o", "d", "n", "u", "m", " " , "á", "l", "o"};
Console.WriteLine("\n [ INVERTER MESSAGEM ] \n ");


msgs.Reverse();
Console.WriteLine("\nMessagem:\n");

foreach (var item in msgs)
{
    Console.WriteLine($" {item} ");
}


