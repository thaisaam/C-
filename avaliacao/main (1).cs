using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine ("digite a area do retangulo");
    String area = Console.ReadLine();

     int area1 = int.Parse(area);
    Console.WriteLine("digite a base do retangulo");
    String base1 = Console.ReadLine();
    int base2 = int.Parse(base1);
    Console.WriteLine("digite a altura do retangulo");
    String altura = Console.ReadLine();
    int altura1 = int.Parse(altura);

    int area2 = base2 * altura1;
    Console.WriteLine("a area do retangulo é: " + area2);

    
    
    
  }
}