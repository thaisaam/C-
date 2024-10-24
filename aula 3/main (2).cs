using System;

class Program {
  public static void Main (string[] args) {
    //Exemplo 3
    //Capturando o primeiro valor
    Console.WriteLine("Primeira nota:");
    string nota1 = Console.ReadLine();
    int nota1_int = int.Parse(nota1);

    //Capturando o segundo valor
    Console.WriteLine("Segunda nota:");
    string nota2 = Console.ReadLine();
    int nota2_int = int.Parse(nota2);

    //Capiturando o terceiro valor
    Console.WriteLine("Terceira nota:");
    string nota3 = Console.ReadLine();
    int nota3_int = int.Parse(nota3);
    
    //Calculando a media
    int soma= nota1_int + nota2_int + nota3_int;
    int media = soma / 3;
    //Exibindo o resultado
    Console.WriteLine("A media dos tres notas é: " + soma / 3);

        
    
      }
    }
