using System;

public class Intervalos {

  public static void Main(string[] args)
  {
    // Lendo o número de entrada
    double numero = double.Parse(Console.ReadLine());

    // Verificando em qual intervalo se encontra
    if (numero >= 0 && numero <= 25)
    {
      Console.WriteLine("O numero se encontra no intervalo entre [0, 25]");
    }
    else if (numero > 25 && numero <= 50)
    {
      Console.WriteLine("O numero se encontra no intervalo entre [25,50]");
    }
    else if (numero > 50 && numero <= 75)
    {
      Console.WriteLine("O numero se encontra no intervalo entre [50, 75]");
    }
    else if (numero > 75 && numero <= 100)
    {
      Console.WriteLine("O numero se encontra no intervalo entre [75, 100]");
    }
    else
    {
      Console.WriteLine("O numero informado nao esta no intervalo");
    }
  }
}
