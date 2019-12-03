using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



public class Juridico:Usuario{

  List<Usuario> usuarios = new List<Usuario>();
  
  
  private string cnpj;


  public Juridico(){
    cnpj = "cnpj";
   
  }
  
  public  Juridico(string n ,string e , string cp,string s,string cn): base(n,e,s,cp ){

    cnpj = cn;

  }

  
   public string getCNPJ(){
     return cnpj;
   }

   public void setCNPJ(string cn){
      cnpj= cn;
   }

    public  void CadastroUsuarioJuridico(string n, string e ,string  cp, string  s, string cn ){
    int id = qtdLinhas();
    if(VerificarCadastro(email)){
 
    StreamWriter streamWriter = File.AppendText("PessoaJuridica.txt");
    streamWriter.WriteLine(n +";" + e  + ";" + id + ';' + cp +';'+s +';'+cn);
    streamWriter.Close();
    }
    else{
      Console.WriteLine("Esse email já foi cadastrado");
    }
        
    
  } 

  private void AtualizarLista(){
    
    string[] linhas = File.ReadAllLines
    
    ("PessoaJuridica.txt");
      

    usuarios.Clear();
   
    
    foreach(string linha in linhas){
 
      string[] dados = linha.Split(";");
 
      Fisico usuario = new Fisico(dados[0],dados[1],dados[2], dados[3] , dados[4]);
      usuarios.Add(usuario);
      
    }
  } 

  public static int qtdLinhas(){
    FileStream  leiturarqvoluntario= new FileStream("PessoaJuridica.txt",FileMode.Open,FileAccess.Read);
    StreamReader lerinfobasic =new StreamReader(leiturarqvoluntario,Encoding.UTF8);
    int id = 1;
    while(!lerinfobasic.EndOfStream){
      lerinfobasic.ReadLine();
      id++;
    } 
    lerinfobasic.Close();
    leiturarqvoluntario.Close();
    return id;
  }
  
  public bool  VerificarCadastro(string email){
    
    AtualizarLista();
    
    foreach(Usuario  u in usuarios){
      if ( email == u.getEmail() ){

        return false;
      }

    } 

    return true;

  }



  public bool LoginJ( string email, string senha){

      

     AtualizarLista();
    
    foreach(Usuario  u in usuarios){
      if ( email == u.getEmail() && senha == u.getSenha() ){
        
           return true;
      }
    } 
    return false;

 

  }
  

}