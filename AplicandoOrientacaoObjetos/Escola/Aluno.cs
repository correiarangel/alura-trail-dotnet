namespace Escola
{
    class Aluno
    {
        private string _nome;
        private int _idade;
        private List<decimal> _notas;

        public Aluno(string nome, int idade, List<decimal> notas)
        {
            _nome = nome;
            _idade = idade;
            _notas = notas;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }
        public List<decimal> Notas { get => _notas; set => _notas = value; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {_nome}, Idade: {_idade}, Notas: {string.Join(", ", _notas)}");
        }
    }
}