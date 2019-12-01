using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class Loja{
   
  List<Produto> produtos = new List<Produto>();
  
  public void comprarumproduto(int id){
      
  }

  private void CarregarProduto(){

    string[] linhas = File.ReadAllLines("produtoparavenda.txt");
    
    foreach(string linha in linhas){
      string[] dados = linha.Split(";");
      Produto p = new Produto(dados[0], float.Parse(dados[1]), Int16.Parse(dados[2]),Int16.Parse(dados[3]));
      produtos.Add(p);
      
    }
    
  }

  public void MostrarProduto(){
    CarregarProduto();
    foreach(Produto p in produtos){
      Console.WriteLine(p.ToString());
    }
  }

  public void BuscarPorID(int id ){
     foreach(Produto p in produtos){
      if ( id == p.getId() ){
        Console.WriteLine(p.ToString());
        
      }

    } 
  }

  public void ComprarProduto( int id  ,int quantidade){
    
    foreach(Produto p in produtos){
      if ( id == p.getId()){
          p.setQuantidade(p.getQuantidade()-quantidade);        Console.WriteLine(p.ToString());
      }

    }
  }

  public void SalvarTxt(){
      
    List <string> ListaProArquivo = new List<string>();

    foreach (Produto linha in produtos){
        ListaProArquivo.Add(linha.nomeProduto + ";" +linha.valor + ";" + linha.getQuantidade() + ";" + linha.getId());
    }

    File.WriteAllLines("produtoparavenda.txt",ListaProArquivo);
    
    
  }

    

  
 


}

