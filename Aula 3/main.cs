usando Sistema;
usando Modelos;

classe Aula3 {
  
  público estático vazio Principal (string[ ] args) {
    Aluno aluno1 = novo Aluno {
      Matrícula = "20212ENEL0195" ,
      Nome = "Paulo" ,
    };
    Impressora.impressão(aluno1);
    
    Aluno aluno2 = novo Aluno( );
    Impressora.impressão(aluno2);
    
    Aluno aluno3 = novo Aluno(2);
    Impressora.impressãoimpressão(aluno3);
    
    Aluno aluno4 = novo Aluno("20212ENEL123", "Sarmento");
    Impressora.impressão(aluno4);
    
    Aluno aluno5 = novo Aluno("20212ENEL012", "Brenin", 3);
    Impressora.impressão(aluno5);

    
    Disciplina disciplina1 = novo Disciplina (0);

    Disciplina disciplina2 = new Disciplina (11);
      

    Impressora.print (disciplina1);
    Impressora.print (disciplina2);






    
  }
}