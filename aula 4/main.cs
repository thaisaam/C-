using System;

class Carro{
  //Propriedades do carro
  public string Marca{get;set; }
  public string Modelo{get;set; }

  public void ExibirInfo(){
    Console.WriteLine($"Carro: {Marca} {Modelo}");
  }


    }

class Program {
  public static void Main (string[] args) {
   Carro meuCarro = new Carro();
    meuCarro.Marca = "Nissan";
    meuCarro.Modelo = "GTR";

    //chamando os meodos
    meuCarro.ExibirInfo();
  }
}