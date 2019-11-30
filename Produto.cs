class Produto{
  public string nomeProduto{get;set;}
  public float  valor{get;set;}
  public int  quantidade{get;set;}

   public Produto(){

    nomeProduto = "Nome";
    valor = 0;
    quantidade = 0;
  }
  public override string ToString(){
    return "\nNome do  Produto: " + nomeProduto + "\nValor de cada Produto: " + valor + "\nQuantidade de Produto: " + quantidade;
  }

  public Produto(string np, float v, int q){

    nomeProduto = np;
    valor = v;
    quantidade = q;
  }

  


}