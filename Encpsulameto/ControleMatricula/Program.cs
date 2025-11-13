Console.WriteLine("\n*** Controle de matrícula ***\n");



Curso curso = new Curso("Lógica de Programação", 3);
curso.Matricular(new Estudante("Penelope Gostosa")); 
curso.Matricular(new Estudante("Dique Vigarista"));
curso.Matricular(new Estudante("João Grandão"));
curso.Matricular(new Estudante("Perter Perfeito")); 
curso.ListarMatriculados();

/*

Classe Curso:

Propriedade pública Nome
Propriedade pública VagasTotais (definida no construtor)
Campo privado matriculas (lista de estudantes)
Método bool Matricular(Estudante estudante) que:
Adiciona o estudante se houver vaga
Exibe mensagem de erro e retorna false caso contrário
Método ListarMatriculados(), que mostra todos os estudantes matriculados
Propriedade somente leitura VagasDisponiveis
Classe Estudante:

Propriedade pública Nome (com construtor)

*/