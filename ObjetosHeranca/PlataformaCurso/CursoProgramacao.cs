namespace PlataformaCurso
{
    class CursoProgramacao(string titulo, Instrutor instrutor) : ICurso
    {
        private string Titulo = titulo;
        private Instrutor Instrutor = instrutor;

        public void ValidarConteudo()
        {
            Console.WriteLine($"Validando conteúdo do curso de programação: {Titulo}");
        }

        public void PublicarCurso()
        {
            Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutora: {Instrutor.Nome} ({Instrutor.Especialidade})\n");
        }
    }
}