using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class Loja{
   
    string str;
    string str2;

    List<Produto> produto = new List<Produto>();
    
    
    public void ComprarProduto(){

      FileStream meuArq = new FileStream("produtoparavenda.txt", FileMode.Open, FileAccess.Read);

      StreamReader sr = new StreamReader(meuArq, Encoding.UTF8);


      FileStream meuArq2 = new FileStream("QuantidadeAtual.txt", FileMode.Open, FileAccess.Read);

      StreamReader sr2 = new StreamReader(meuArq2, Encoding.UTF8);
      
    
      while(!sr.EndOfStream){
        /*
        str = sr.ReadLine();
        str2 = sr2.ReadLine();
      

        string nomeProduto;
        int quantidade;
        float valor;

        nomeProduto = String.Join("", System.Text.RegularExpressions.Regex.Split(str, @"[\d| -]"));

        valor = float.Parse(String.Join("", System.Text.RegularExpressions.Regex.Split(str, @"[^\d]")));

        quantidade = int.Parse(str2);
        produto.Add(new Produto(nomeProduto,valor,quantidade));
        */
        //Console.WriteLine(nomeProduto+" - "+ valor + " - "+quantidade);

      }
    }
    public void MostrarProduto(){

      foreach(Produto p in produto){
        Console.WriteLine(p);
      }
    }
    }



