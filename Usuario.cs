using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Usuario{

  List<Usuario> usuarios = new List<Usuario>();

  private string email;
  private string nome;
  private string cep;

  private string senha;
  
  public string getEmail(){
    return email;
  }


  public string getNome(){
    return nome;
  }

 
  public void setEmail(string e){
    email = e;
  }

  public void setNome(string n){
    nome = n;
  }

  public string getCep(){
    return cep;
  }

 
  public void setCep(string cp){
    cep = cp;
  }


  public string getSenha(){
    return senha;
  }

 
  public void setSenha(string s){
    senha = s;
  }



  public Usuario(){
    nome = "Nome";
    email = "Email";
    cep = "dfaf";
    senha = "9erwr3";
 
  }

   public Usuario( string n ,string e , string cp,string s){
    nome = n;
    email = e;
    cep = cp;
    senha = s;

  }
 

  public  void CadastroUsuario(string n, string e ,string  cp, string  s ){
    int id = qtdLinhas();
    if(VerificarCadastro(email)){
 
    StreamWriter streamWriter = File.AppendText("CadastroUsuario.txt");
    streamWriter.WriteLine(n +";" + e  + ";" + id + ';' + cp +';'+s);
    streamWriter.Close();
    }
    else{
      Console.WriteLine("Esse email já foi cadastrado");
    }
        
    
  } 

  private void AtualizarLista(){
    
    string[] linhas = File.ReadAllLines("CadastroUsuario.txt");
    usuarios.Clear();
   
    
    foreach(string linha in linhas){
 
      string[] dados = linha.Split(";");
 
      Usuario usuario = new Usuario(dados[0],dados[1],dados[2], dados[3]);
      usuarios.Add(usuario);
      
    }
  } 

  public static int qtdLinhas(){
    FileStream  leiturarqvoluntario= new FileStream("CadastroUsuario.txt",FileMode.Open,FileAccess.Read);
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

  private bool  VerificarCadastro(string email){
    
    AtualizarLista();
    
    foreach(Usuario  u in usuarios){
      if ( email == u.getEmail() ){

        return false;
      }

    } 

    return true;

  }

  public bool Login( string email, string senha){
     AtualizarLista();
    
    foreach(Usuario  u in usuarios){
      if ( email == u.getEmail() && senha == u.getSenha() ){
        
           return true;
      }
    } 
    return false;

 

  }
  


  

}