namespace PlataformaCurso
{
    class CursoDesign(string titulo, Instrutor instrutor) : ICurso
    {
        private string Titulo = titulo;
        private Instrutor Instrutor = instrutor;

        public void ValidarConteudo()
        {
            Console.WriteLine($"Validando conteúdo do curso de design: {Titulo}");
        }

        public void PublicarCurso()
        {
            Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutor: {Instrutor.Nome} ({Instrutor.Especialidade})\n");
        }
    }
}