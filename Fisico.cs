using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
// Classe físico herda usuário
public class  Fisico : Usuario{

  List<Usuario> usuarios = new List<Usuario>();

  
  
  private string cpf;

// Construtores
  public Fisico(){
    cpf = "CPF";
   
  }
  
  public Fisico(string n ,string e , string cp,string s,string c ): base(n,e,cp,s){

    cpf = c;

  }

  
   public string getCPF(){
     return cpf;
   }

   public void setCPF(string c){
      cpf = c;

   }
// Verificação de cadastro de usuário
   public bool  VerificarCadastro(string email){
    
    AtualizarLista();
    
    foreach(Usuario  u in usuarios){
      if ( email == u.getEmail() ){

        return false;
      }

    } 

    return true;

  }
  // Leitura de arquivo voluntário
  public static int qtdLinhas(){
    FileStream  leiturarqvoluntario= new FileStream("PessoaFisica.txt",FileMode.Open,FileAccess.Read);
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

// cadastro de usuário
 public  void CadastroUsuario(string n, string e ,string  cp, string  s, string cf ){
    int id = qtdLinhas();
    if(VerificarCadastro(email)){
 
    StreamWriter streamWriter = File.AppendText("PessoaFisica.txt");
    streamWriter.WriteLine(n +";" + e  + ";" + id + ';' + cp +';'+s +';'+cf );
    streamWriter.Close();
    }
    else{
      Console.WriteLine("Esse email já foi cadastrado");
    }
        
    
  } 
// Atualização de lista
  private void AtualizarLista(){
    
    string[] linhas = File.ReadAllLines
    
    ("PessoaFisica.txt");
      

    usuarios.Clear();
   
    
    foreach(string linha in linhas){
 
      string[] dados = linha.Split(";");
     
 
      Fisico usuario = new Fisico(dados[0],dados[1],dados[2], dados[3] , dados[4]);
      usuarios.Add(usuario);
      
    }
  } 
// Sessão de login
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