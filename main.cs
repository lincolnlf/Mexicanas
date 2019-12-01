using System.IO;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Text;

class MainClass {
   
  public static void Main (string[] args) {

    Loja loja = new Loja();

    loja.MostrarProduto();
  
    Console.WriteLine("Buscar o codigo do produto:");
    int id  = int.Parse(Console.ReadLine());

    

    loja.BuscarPorID(id);

    Console.WriteLine("Digite a quantidade que você quer comprar: ");
    int quantidade = int.Parse(Console.ReadLine());

    loja.ComprarProduto(id,quantidade);

  }


}