namespace Modelos;

public class Produto : Registro
{
    string nome;
    string bairronoufacção;
    string tempoestimado;
    string valor;
    string quantidade;
    int id;
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

     protected void SetBairronouFacção (string bairron)
    {
       this.bairronoufacção = bairron;
    }
     protected string Getb ()
    {
       return bairronoufacção;
    }
     //______________________________________
      protected void Setquantidade (string quantidade)
    {
       this.quantidade = quantidade;
    }
     protected string Getquantiade ()
    {
       return quantidade;
    }
    //______________________________________
     protected void SetValor (string RS)
    {
       this.valor = RS;
    }
     protected string GetValor ()
    {
       return valor;
    }
    //______________________________________
     protected void Setid (int id)
    {
       this.id = id;
    }
     protected int Getid ()
    {
       return id;
    }
    //______________________________________
     protected void Settempoestimado (string tempo)
    {
       this.tempoestimado = tempo;
    }
     protected string GetTempostimado ()
    {
       return tempoestimado;
    }
    //______________________________________

}  