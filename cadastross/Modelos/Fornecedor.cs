namespace Modelos;

public class Fornecedor : Pessoa
{
    string nome;
    string Endereço;
    string numero;
    string cpf;
    string cidade;
    string estado;
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
     protected string GetEndereço ()
    {
       return Endereço;
    }
     //______________________________________

     protected void Setnumero (string numero)
    {
       this.numero = numero;
    }
     protected string Getnumero ()
    {
       return numero;
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
   
     protected void Setcidade (string cidade)
    {
       this.cidade = cidade;
    }
     protected string Getcidade ()
    {
       return cidade;
    }
    //______________________________________
     protected void Setestado (string estado)
    {
       this.estado = estado;
    }
     protected string Getestado ()
    {
       return estado;
    }
}  