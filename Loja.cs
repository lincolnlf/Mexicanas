using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class Loja{
   
    List<Produto> produtos = new List<Produto>();
    
    public void comprarumproduto(int id){
        
    }

    public void ComprarProduto(){

      string[] linhas = File.ReadAllLines("produtoparavenda.txt");
      
      foreach(string linha in linhas){
        string[] dados = linha.Split(";");
        Produto p = new Produto(dados[0], float.Parse(dados[1]), Int16.Parse(dados[2]),Int16.Parse(dados[3]));
        produtos.Add(p);
        
      }
      
    }

    public void MostrarNaLista(){     
    }

    

    }



