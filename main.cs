
using System;


class MainClass {
   
  public static void Main (string[] args) {

  
    Console.WriteLine("Digite seu nome para cadastro:");
    string nome  = (Console.ReadLine());

    Console.WriteLine("Digite seu email para cadastro:");
    string  email = (Console.ReadLine());

    Usuario usuario = new Usuario(nome,email);

    usuario.CadastroUsuario(nome, email);

    
  }


}