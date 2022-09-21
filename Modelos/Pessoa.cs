namespace Modelos {

  classe Pessoa {

    privado string cpf;

    público string Cpf {
      obter = > isto.cpf;
      conjunto {
        se (Validar(valor) ) {
          isto.cpf = valor;
        }
      }
    }

    público estático bool Validar(string cpf) {
      int[ ] multiplicador1 = novo int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
  		int[ ] multiplicador2 = novo int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
  		string tempCpf;
  		string digito;
  		int soma;
  		int resto;
  
  		cpf = cpf.Aparar( );
  		cpf = cpf.Substituir(".", "").Substituir("-", "");
  
  		se (cpf.Comprimento != 11)
  		   Retorna falso;
  
  		tempCpf = cpf.Substringir(0, 9);
  		soma = 0;
  
  		para(int eu=0; eu<9; eu+ +)
  		    soma + = int.Parse(tempCpf[eu].ToString( ) ) * multiplicador1[eu];
  
  		resto = soma % 11;
  		se ( resto < 2 )
  		    resto = 0;
  		mais
  		   resto = 11 - resto;
  
  		digito = resto.ToString( );
  
  		tempCpf = tempCpf + digito;
  
  		soma = 0;
  		para(int eu=0; eu<10; eu+ +)
  		    soma + = int.Parse(tempCpf[eu].ToString( ) ) * multiplicador2[eu];
  
  		resto = soma % 11;
  		se (resto < 2)
  		   resto = 0;
  		mais
  		   resto = 11 - resto;
  
  		digito = digito + resto.ToString( );
  
  		Retorna cpf.Termina com(digito);
    }

    público string Nome {
      obter; conjunto;
    }
    
  }
  
}