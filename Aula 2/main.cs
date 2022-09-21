usando Sistema;

classe Aula2{


  público estruturar Aluno {
    público string Matrícula; 
    público int Periodo;
  }

  público estruturar Disciplina {
    público string Nome;
    público int semestre;
  }

  público estático bool MatricularMatricular(Aluno aluno, Disciplina disciplina) {

    Retorna aluno.Periodo = = disciplina.semestre;
    
  }

  público estático vazio Imprimir(Aluno aluno, Disciplina disciplina) {
      se (Matricular(aluno, disciplina) ) {
        Console.WriteLine(aluno.Matrícula);
      }
    }
  

  público estático vazio Principal (string[ ] args) {

    Aluno aluno1 = novo Aluno1 {
      Matrícula = "012521",
      Periodo = 1
    };
    
    Aluno aluno2 = novo Aluno2 {
      Matrícula = "022033",
      Periodo = 3
    };

    Disciplina disciplina = novo Disciplina {
      Nome = "Linguagem de Programacao",
      semestre = 3
    };

    Imprimir(aluno1, disciplina);
    Imprimir(aluno2, disciplina);
  }
}