using PlataformaCurso;

Console.WriteLine("\n*** Sistema cadastro de pagamentos ***\n");



Instrutor instrutor1 = new Instrutor("Formiga Atomica", "Back-end");
ICurso curso1 = new CursoProgramacao("C# com POO", instrutor1);
 
Instrutor instrutor2 = new Instrutor("Raul Seixas", "UI/UX");
ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);
 
curso1.ValidarConteudo();
curso1.PublicarCurso();
 
curso2.ValidarConteudo();
curso2.PublicarCurso();