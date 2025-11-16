Console.WriteLine("\n*** Sistema cadastro certificado de profissões ***\n");


Analista analista = new Analista("Analista de Sistemas", "Rangel");
Docente docente = new Docente("Docente Universitário", "Maria");

Certificado cerf1 = new Certificado(analista);
Certificado certf2 = new Certificado(docente);


cerf1.ExibirCertificado();
certf2.ExibirCertificado();
