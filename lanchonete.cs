using System;

public class Lanchonete {

  public static void Main(string[] args)
  {
    // Lendo o código e a quantidade
    string[] entrada = Console.ReadLine().Split(' ');
    int codigo = int.Parse(entrada[0]);
    int quantidade = int.Parse(entrada[1]);

    // Cálculo do valor total
    double total = 0;
    switch (codigo)
    {
      case 1:
        total = quantidade * 4.00;
        break;
        
      case 2:
        total = quantidade * 4.50;
        break;

      case 3:
        total = quantidade * 5.00;
        break;

      case 4:
        total = quantidade * 2.00;
        break;

      case 5:
        total = quantidade * 1.50;
        break;
    }

    // Imprime o valor total
    Console.WriteLine($"Total: R$ {total:F2}");
    
  }
}
