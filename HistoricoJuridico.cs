using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class HistoricoJuridico{

  public string email{get;set;}
  public int   quantidade{get;set;}
  public int  id{get;set;}

  List<HistoricoJuridico> historicojuridico
   = new List<HistoricoJuridico>();

  public  HistoricoJuridico(){
    email = "4444";
    quantidade = 0;
    id = 0;
  
  }
  
  public HistoricoJuridico(string e, int q, int i){
    email = e;
    quantidade =q;
    id = i;
  }

 


  public  void ColocandoNoHistorico(string e, int q, int i ){
   
    StreamWriter streamWriter = File.AppendText("HistoricoJuridico.txt");
    streamWriter.WriteLine(e+";" + q + ";" + i );
    streamWriter.Close();

  }
   
  private void AtualizarHistorico(){
    
    string[] linhas = File.ReadAllLines
    
    ("HistoricoJuridico.txt");
      

    historicojuridico.Clear();
    
    foreach(string linha in linhas){
  
      string[] dados = linha.Split(";");
    
      HistoricoJuridico hj= new HistoricoJuridico(dados[0],Int16.Parse(dados[1]),Int16.Parse(dados[2]));
      historicojuridico.Add(hj);
        
      }
  } 


  public void  MostrarHistorico(string email){
    
    AtualizarHistorico();
    
    foreach(HistoricoJuridico   h in historicojuridico){
      if ( email == h.email){
        Console.WriteLine("A quantidade de produto"+h.quantidade);

        Console.WriteLine(h.id);

        Console.WriteLine(h.email);

        
    
      }

    } 

  }
  


}