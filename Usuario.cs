using System.IO;
using System.Text;


class Usuario{

  private string email;
  private string nome;
  


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

  public Usuario(){
    nome = "Nome";
    email = "Email";
 
  }

   public Usuario( string n ,string e){
    nome = n;
    email = e;

  }
 

  public  void CadastroUsuario(string n, string e){

    StreamWriter streamWriter = File.AppendText("CadastroUsuario.txt");
    streamWriter.WriteLine(n +";" + e );
    streamWriter.Close();
      
    
    
  }

  

}