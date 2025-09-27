int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };

Console.WriteLine("\n [ DECIFRA CADEIA DE NUMEROS ] \n ");



Console.WriteLine("\nDecifrado...\n");

int pos1 = Array.IndexOf(numeros, 19);
int pos2 = Array.IndexOf(numeros, 42);
int pos3 = Array.IndexOf(numeros, 7);

Console.WriteLine($"\nCombinação do cadeado: {pos1} {pos2} {pos3}\n");

