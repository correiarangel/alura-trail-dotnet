using ScreenSound.Models;

namespace ScreenSound.Menu
{
    internal class Menu
    {

        public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
        }

        public virtual void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
    }
}