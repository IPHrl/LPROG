using Modelos;

class Aula4 {

  public static void Main (string[] args) {

    Aluno aluno1 = new Aluno(0);
    aluno1.Periodo = 0;
    Impressora.print(aluno1);

    Aluno aluno2 = new Aluno();
    Impressora.print(aluno2);
    
    Aluno aluno3 = new Aluno(2);
    Impressora.print(aluno3);
    
    Aluno aluno4 = new Aluno("20212ENEL001", "PAGAGUIN");
    Impressora.print(aluno4);
    
    Aluno aluno5 = new Aluno("20212ENEL002", "PAGAGUINLEGAL", 3);
    Impressora.print(aluno5);

   
 
  Disciplina disciplina1 = new Disciplina(0);
  Impressora.print(disciplina1);
    
  Disciplina disciplina2 = new Disciplina {
    
    };
  Impressora.print(disciplina2);
    
  Disciplina disciplina3 = new Disciplina(11);
  Impressora.print(disciplina3);
  }
}