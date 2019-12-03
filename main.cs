
using System;


class MainClass {
   
  public static void Main (string[] args) {

    Console.WriteLine("Digite a opção 1 para cadastrar\n digite a opção 2 para entrar no sistema:");
    string opcao  = (Console.ReadLine());
    

    if (opcao == "1"){

    
    Console.WriteLine("Digite seu nome para cadastro:");
    string nome  = (Console.ReadLine());

    Console.WriteLine("Digite seu email para cadastro:");
    string  email = (Console.ReadLine());
   
  
    Console.WriteLine("Digite seu cep:");
    string  cep = (Console.ReadLine());

    Console.WriteLine("Digite sua senha para cadastrar:");
    string  senha  = (Console.ReadLine());

    Console.WriteLine("Digite sua senha para cadastrar:");
    string  cnpj  = (Console.ReadLine());

    
    Juridico usuario = new Juridico(nome,email,cep,senha,cnpj);

    usuario.CadastroUsuarioJuridico(nome, email,cep,senha,cnpj);
    


    }

    

    if (opcao == "3"){

    
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

    
    Fisico usuario = new Fisico(nome,email,cep,senha,cpf);

    usuario.CadastroUsuario(nome, email,cep,senha,cpf);
    


    }

    if(opcao == "2"){

    Juridico usuario = new Juridico();

    Fisico usuarioFisico = new Fisico();

    Loja loja = new Loja();


    Console.WriteLine("Digite seu email  de cadastro:");
    string  email = (Console.ReadLine());

    Console.WriteLine("Digite sua senha:");
    string  senha  = (Console.ReadLine());

     if(usuarioFisico.Login( email,senha)  || usuario.LoginJ(email,senha)){
    
      
      loja.MostrarProduto();
      Console.WriteLine("você pode fazer a compra");

      

      Console.WriteLine("Digite o id do produto:");
      int  id  =int.Parse(Console.ReadLine());

      Console.WriteLine("Digite a quantidade que você quer comprar:");
      
      int  quantidade  =  int.Parse(Console.ReadLine());

      


      loja.BuscarPorID(id );

      loja.ComprarProduto(id,quantidade);

      loja.ValorCompra(id,quantidade);

      loja.SalvarTxt();

     }

    
    }  
   

  }


}