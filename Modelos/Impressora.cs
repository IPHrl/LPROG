using System;

namespace Modelos {

  class Impressora {

    public delegate string Linha();

    public static string LinhaComum() { return "=======================================================";
    }
                                       
    public static void print(Texto texto){

      print(texto, LinhaComum, LinhaComum);
    }
    
    public static void print(Texto texto, Linha cabecalho, Linha rodape) {
    
      Console.WriteLine(cabecalho());
      Console.WriteLine(texto.Informar());   
      Console.WriteLine(rodape());
      
    }
    
    public static void print(Pessoa pessoa) {
    Console.WriteLine(
     
    );
  } 
    
    public static void print(Professor professor) {
    Console.WriteLine(
    "Código: " + professor.Codigo
    );
  } 
    
    public static void print(Aluno aluno) {
    Console.WriteLine(
     
    );
  }
    
    public static void print(Disciplina disciplina) {
    Console.WriteLine(
    "Nome: " +
      disciplina.Nome + "\n" + "Semestre: " 
      + disciplina.Semestre
    );
  }

    public static void print(Contato contato) {
    Console.WriteLine(
    contato.Informar()
    );
  } 
    
 }

}