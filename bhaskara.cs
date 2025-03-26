using System;

public class Bhaskara {

  public static void Main(string[] args)
  {
    // Lendo os valores de entrada
    string[] valores = Console.ReadLine().Split(' ');
    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);

    // Cálculo do discriminante
    double delta = Math.Pow(b, 2) - 4 * a * c;

    // Verificando se o cálculo das raízes é possível
    if (a == 0 || delta < 0)
    {
      Console.WriteLine("Impossivel calcular...");
    }
    else
    {
      // Cálculo das raízes
      double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
      double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

      // Imprime o resultado das raízes
      Console.WriteLine($"R1 = {r1:F5}");
      Console.WriteLine($"R2 = {r2:F5}");
    }
  }
}
