using System;

public class ValoresAceitos{

  public static void Main(string[] args)
  {
    // Lendo os valores de entrada
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Pars(valores[1]);
    int c = int.Parse(valores[2]);
    int d = int.Parse(valores[3]);

    // Verificando condições
    if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
    {
      // Se todas forem aceitas, imprime "Valores aceitos"
      Console.WriteLine("Valores aceitos");
    }
    else
    {
      // Caso contrário, imprime "Valores nao aceitos"
      Console.WriteLine("Valores nao aceitos");
    }
  }
