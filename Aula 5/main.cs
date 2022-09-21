usando Modelos;

classe Aula5 {

  público estático vazio Principal (string[ ] args) {
    Aluno aluno1 = novo Aluno(0);
    aluno1.Cpf = "422.657.877 - 99";
    Impressora.Imprimir(aluno1);
    Aluno aluno2 = novo Aluno(1);
    aluno2.Cpf = "660.036.460 - 20";
    Impressora.Imprimir(aluno2);
    Pessoa Pessoa1 = novo PessoaPessoa( );
    Pessoa1.Cpf = "588.401.710 - 37";
    Impressora.Imprimir(Pessoa1);
    Pessoa pessoa2 = (Pessoa) aluno2;
    Impressora.ImprimirImprimir(pessoa2);
    Aluno aluno3 = (Aluno) pessoa2;
    Impressora.Imprimir(aluno3);
    Professor professor1 = novo Professor( );
    professor1.Cpf = "851.152.090 - 20";
    Impressora.Imprimir(professor1);
  }

}