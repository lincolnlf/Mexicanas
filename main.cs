
using System;


class MainClass {
   
  public static void Main (string[] args) {

  Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

  
  Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("========================================================  MEXICANAS  ==========================================================");

  Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

  Console.ForegroundColor = ConsoleColor.White; 

  Console.WriteLine();


  Console.WriteLine(" Para entrar no nosso sistema: \n Informe se você é uma pessoa fisica ou uma pessoa juridica:");

  Console.WriteLine();

  Console.WriteLine(" Digite 1 para Pessoa fisica\n =============================\n Digite 2 para Pessoa Juridico");
  string resp  = (Console.ReadLine());


  Console.WriteLine();

   int opcao = 0;
  

  while(resp == "1" || opcao == 1){

    Console.WriteLine("Digite 1 para fazer um cadastro no nosso Sistema:");
    opcao = int.Parse(Console.ReadLine());


     
    if (opcao == 1){

    
    Console.WriteLine("Digite seu nome para cadastro:");
    string nome  = (Console.ReadLine());

    Console.WriteLine("Digite seu email para cadastro:");
    string  email = (Console.ReadLine());
   
  
    Console.WriteLine("Digite seu cep:");
    string  cep = (Console.ReadLine());

    Console.WriteLine("Digite sua senha para cadastrar:");
    string  senha  = (Console.ReadLine());

    Console.WriteLine("Digite sua senha para cadastrar:");
    string  cpf  = (Console.ReadLine());

    
    Fisico  usuario = new Fisico(nome,email,cep,senha,cpf);

    usuario.CadastroUsuarioFisico(nome, email,cep,senha,cpf);
    Console.ForegroundColor = ConsoleColor.White; 
    break;
      }
    }
  }   
}