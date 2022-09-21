namespace Modelos {

  classe Aluno {
    
    privado int periodo;
    

    público int Periodo {
      obter = > isto.periodo;
      conjunto {
        se (valor > 0) {
        isto.periodo = valor;
        }  mais{
         isto.periodo = 1;
           }
      }
    }

    público string Nome {
      obter; conjunto;
    }

    público string Matrícula{
      obter; conjunto;
    }
    
    público Aluno ( ) : isto(0) {
    }
    
    público Aluno(int Periodo) {
      isto.Periodo = periodo;
    }

    público Aluno(string matricula, string nome)  :  isto( ) {
      isto.Matrícula = matricula;
      isto.Nome = nome;
    }

    público Aluno(string matricula, string nome, int periodo)  :  isto(periodo) {
      isto.Matrícula = matricula;
      isto.Nome = nome;
      
    }
      
    público bool Matricular(Disciplina disciplina) {
      Retorna isto.Periodo = = disciplina.semestre;
    }
  }
} 