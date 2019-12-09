
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

  Console.WriteLine(" Digite 1 para Pessoa fisica:\n =============================\n Digite 2 para Pessoa Juridico:");
  string resp  = (Console.ReadLine());


  Console.WriteLine();

   int opcao = 0;
   
    HistoricoFisico historicoFisico = new HistoricoFisico();
    
    Console.WriteLine("Digite 89 para poder sair do programa:");
    Console.WriteLine("Digite 1 para fazer um cadastro no nosso Sistema:\nDigite 2 se você já é cadastrado:");
    opcao = int.Parse(Console.ReadLine());


  

  while(resp == "1" || opcao == 1 || opcao == 2){

    

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

    if(opcao == 2){

      Fisico  usuario = new Fisico();

      Console.WriteLine("Digite seu email:");
      string  email = (Console.ReadLine());

      Console.WriteLine("Digite sua senha:");
      string  senha = (Console.ReadLine());

      Console.WriteLine();

      if(usuario.Login(email,senha)){

      int opcaoUsuario = 0;

      Console.WriteLine();

      

      Console.WriteLine("\nDigite 1 para poder fazer uma compra:\nDigite 2 para verficar seu historico de compra em nossa loja:");
      opcaoUsuario = int.Parse(Console.ReadLine());

      if(opcaoUsuario == 1){

        Loja loja = new Loja();

        Console.WriteLine("Esse são todos os nossos produtos para venda:");

        loja.MostrarProduto();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();

        Console.WriteLine("Digite o ID do produto que você deseja comprar:");
        int   id  = int.Parse(Console.ReadLine());
       

        if(loja.BuscarPorID(id)){

        
        Console.WriteLine();
        Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
        int   quantidade = int.Parse(Console.ReadLine());
        historicoFisico.ColocandoNoHistorico(email,id,quantidade);


        loja.ComprarProduto(id,quantidade);
        Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
        string  desejacompra = Console.ReadLine();
        string desejacompra1 ="";

        while(desejacompra == "s"|| desejacompra1 == "s"){
          
          
    


          if(desejacompra == "s"){

            
        


          Console.WriteLine("Digite o ID do produto que você deseja comprar:");
          int   id1  = int.Parse(Console.ReadLine());

          
          if(loja.BuscarPorID(id1)){
  
  
          Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
          int   quantidade1 = int.Parse(Console.ReadLine());

          loja.ComprarProduto(id1,quantidade1);
          
            
          }
        }
        if(desejacompra != "s"){
            break;
        }

        Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
        desejacompra1 = Console.ReadLine();

        if(desejacompra1 != "s"){
          break;
          }
 
      }

      }
      
      
    
      }
      

      if(opcaoUsuario == 2){
        HistoricoFisico historico = new HistoricoFisico();
        Console.WriteLine("Esse é todo o seu historico em nossa loja");
        historico.MostrarHistorico(email);

      }

  
      if(opcaoUsuario == 89){
        break;
      }
    }    
    }    
    }
  }   
}