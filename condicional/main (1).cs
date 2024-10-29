using System;

class Program {
  public static void Main (string[] args) {
    //solicitano a nota que o aluno tirou
    Console.WriteLine("Insira sua nota (0 a 100): ");
    int nota = int.Parse(Console.ReadLine());
    //verificando se a nota é válida
    if(nota >=0 && nota <=100){
      //verificando se anota azul
      if(nota >= 50){
        Console.WriteLine("Parabens! Voce esta com nota azul");
      }
      
    }else{
      Console.WriteLine("Nota invalida insira outra nota");
    }
    
  }
}