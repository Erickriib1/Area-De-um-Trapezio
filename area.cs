using System;

class Program {
  public static void Main (string[] args) {
  double b1, b2, a, r;
    
    Console.WriteLine("digite o valor da base menor");
    b1 = double.Parse(Console.ReadLine());

    Console.WriteLine("digite o valor da base maior");
    b2 = double.Parse(Console.ReadLine());

    Console.WriteLine("digite o valor da altura");
    a = double.Parse(Console.ReadLine());

    r = ((b1 + b2) * a) / 2;

    Console.WriteLine("o valor da are do trapezio é " + r);

  }
}
