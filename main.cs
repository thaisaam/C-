using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("DIgite alguma coisa no teclado");

    //Capturando a entrada do usuario
    string entrada = Console.ReadLine();

    // Exibindo o que o usuario digitou
    Console.WriteLine("Voce digitou: " + entrada);


    //Exemplo 2

  Console.WriteLine("*********E2*********");
    //Capturando o primeiro valor
    Console.WriteLine("Digite o primeiro valor");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);

    //Capturando o segundo valor
    Console.WriteLine("Digite o segundo valor");
    string valor2 = Console.ReadLine();
    int numero2 = int.Parse(valor2);


    //Calculando a soma
    int soma = numero1 + numero2;
    //Exibindo o resultado
    Console.WriteLine("A soma dos dois numeros é: " + soma);
  }
}