using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Historico{
  public string email{get;set;}
  public int   quantidade{get;set;}
  public int  id{get;set;}

  public  Historico(){
    email = "4444";
    quantidade = 0;
    id = 0;
  
  }
  
  public Historico(string e, int q, int i){
    email = e;
    quantidade =q;
    id = i;
  }

  List<Historico> historicos = new List<Historico>();

// inserindo no histórico
  public  void ColocandoNoHistorico(string e, int q, int i ){
   
    StreamWriter streamWriter = File.AppendText("HistoricoUsuario.txt");
    streamWriter.WriteLine(e+";" + q + ";" + i );
    streamWriter.Close();

  }
// atualização de histórico   
  private void AtualizarHistorico(){
    
    string[] linhas = File.ReadAllLines
    
    ("HistoricoUsuario.txt");
      

    historicos.Clear();
    
    foreach(string linha in linhas){
  
      string[] dados = linha.Split(";");
    
      Historico historico = new Historico(dados[0],Int16.Parse(dados[1]),Int16.Parse(dados[2]));
      historicos.Add(historico);
        
      }
  } 

//vizualização de histórico
  public void  MostrarHistorico(string email){
    
    AtualizarHistorico();
    
    foreach(Historico   h in historicos){
      if ( email == h.email){
        Console.WriteLine("A quantidade de produto"+h.quantidade);

        Console.WriteLine(h.id);

        Console.WriteLine(h.email);

        
    
      }

    } 

  }
  


}