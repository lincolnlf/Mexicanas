class Produto{

  private int id;
  public string nomeProduto{get;set;}
  public float  valor{get;set;}
  private  int  quantidade{get;set;}


  public int getId(){
    return id;
  }

  public int getQuantidade(){
    return quantidade;
  }

  public void setQuantidade(int qtd){
    quantidade = qtd;
  }
  public Produto(){
   
    nomeProduto = "Nome";
    valor = 0;
    quantidade = 0;
    id = 1;
  }

   public Produto( string np, float v, int q,int i){
    
    nomeProduto = np;
    valor = v;
    quantidade = q;
    id = i;
   
  }

  public override string ToString(){
    return  "\nNome do  Produto: " + nomeProduto + "\nValor de cada Produto: " + valor + "\nQuantidade de Produto: " + quantidade +"\nCodigo do Produto:"+ id;
  }

  public string prepararArquivo(){
    return  ";" + nomeProduto + ";" + valor + ";" + quantidade +  ";" + id  ;
  }

 

  


}