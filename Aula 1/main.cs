usando Sistema;

classe Aula1 {
  
  público estático duplo segundograu(duplo x, duplo uma, duplo b, duplo c) {

    Retorna uma*Matemática.Pó(x, 2) + b*x + c;
  }
  
  público estático duplo [ ] zero(duplo uma, duplo b, duplo c) {

    duplo[ ]r = novo duplo[2];
    se(uma != 0) {
      duplo delta = Matemática.Pó(b, 2) - (4*uma*c);
        se(delta> =0) {
          r[0] = (-b+Matemática.Sqrt(delta) ) / (2*uma);
          r[1] = (-b-Matemática.Sqrt(delta) ) / (2*uma);
        }
    } mais {
      r[0] = -c/b;
    }
    Retorna r;
  }
  
  público estático vazio Principal (string[ ] args) {
    
  int v = 0;  
  Console.WriteLine(v);

  duplo y = segundograu(1, 2, 3, 4);
  Console.WriteLine(y);

  duplo [ ] s = zero(1, 2, 3);
  Console.WriteLine(s[0] + " " + s[1] );

  duplo [ ] t = zero(1, 4, 2);
  Console.WriteLine(t[0] + " " + t[1] );



  int [, ] m = novo int [2, 3] {
    {1,2,3}, {4,5,6}
  };

    Console.WriteLine(m[0,1] );

  paraach(int eu em m) {
    Console.WriteLine(eu);
  }

    
    
  }
}