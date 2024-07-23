namespace Modelos;

public class Materia : Registro
{
    string nome;
    string valor;
    string tempodeprodução;
    string quantidade;
    //______________________________________

    public void SetNome (string nome)
    {
       this.nome = nome;
    }
     public string GetNome ()
    {
       return nome;
    }
    //______________________________________

     protected void SetValor(string valor)
    {
       this.valor = valor;
    }
     protected string GetValor ()
    {
       return valor;
    }
     //______________________________________
      protected void setTempodeprodução (string tempodeprodução)
    {
       this.tempodeprodução = tempodeprodução;
    }
     protected string Gettempodeprodução ()
    {
       return tempodeprodução;
    }
       //______________________________________
      protected void Setquantidade (string quantidade )
    {
       this.quantidade = quantidade;
    }
     protected string Getquantiade ()
    {
       return quantidade;
    }
    //______________________________________
    }