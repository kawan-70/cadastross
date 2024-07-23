namespace Modelos;

public class Cliente : Pessoa
{
    string nome;
    string Endereço;
    string gmail;
    string cpf;
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

     protected void SetEndereço (string Endereço)
    {
       this.Endereço = Endereço;
    }
     protected string Getendereço ()
    {
       return Endereço;
    }
     //______________________________________
      protected void setgmail (string gmail)
    {
       this.gmail = gmail;
    }
     protected string Getgmail ()
    {
       return gmail;
    }
    //______________________________________
     protected void Setcpf (string cpf)
    {
       this.cpf = cpf;
    }
     protected string Getcpf ()
    {
       return cpf;
    }
    //______________________________________
}  

