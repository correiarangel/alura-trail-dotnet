Console.WriteLine("\n*** Agenda com controle de contatos duplicados ***\n");

Agenda agenda = new Agenda("Hana Barbera");
agenda.AdicionarContato(new Contato("Don Pixote", "11998887777"));
agenda.AdicionarContato(new Contato("Don Pixote", "11998887777"));
agenda.AdicionarContato(new Contato("Pepi Legal", "21988776655"));

agenda.ListarContatos();



/*

Uma classe Contato, com:
Propriedades públicas Nome e Telefone.
Uma classe Agenda, com:
Propriedade pública Proprietario.
Um campo privado e readonly contatos (do tipo List<Contato>).
Um método público bool AdicionarContato(Contato contato), que verifica se o nome já existe.
Um método ListarContatos(), que imprime os contatos.
Uma propriedade pública somente leitura QuantidadeContatos.

*/