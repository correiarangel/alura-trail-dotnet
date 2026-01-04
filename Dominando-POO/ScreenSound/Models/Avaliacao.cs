namespace ScreenSound.Models;
 internal class Avaliacao{
    public int Nota { get; private set; }

    public Avaliacao(int value){
        if(value <= 0 || value > 10){
            throw new ArgumentOutOfRangeException("O valor da nota deve ser entre 0 e 10.");
        }
        Nota = value;
    }

    public static Avaliacao Parse(string value){
        
        int notaConvertida = int.Parse(value);

        return new Avaliacao(notaConvertida);
    }
}