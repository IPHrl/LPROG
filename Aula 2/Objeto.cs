usando Sistema;
usando Modelos;

classe AulaObjeto{


  público estático vazio Imprimir(Aluno aluno, Disciplina disciplina) {
      se (aluno.MatricularMatricular(disciplina) ) {
        Console.WriteLine(aluno.Matrícula);
      }
    }
  

  público estático vazio Principal (string[ ] args) {

    
    Aluno aluno1 = novo Aluno {
      Matrícula = "012022",
      Periodo = 1
    };
    
    Aluno aluno2 = novo Aluno {
      Matrícula = "022022",
      Periodo = 3
    };

     Disciplina disciplina = novo Disciplina {
      Nome = "Linguagem de Programa",
      semestre = 3
    };

    Imprimir(aluno1, disciplina);
    Imprimir(aluno2, disciplina);
  
  }
}