namespace Modelos;

public class Transportadora : Registro
{
    string nome;
    string Endereço;
    int numero;
    string Valor;
    string percurçopercorrido;
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

     private void SetEndereço (string Endereço)
    {
       this.Endereço = Endereço;
    }
     protected string GetEndereço ()
    {
       return Endereço;
    }
     //______________________________________

     protected void Setnumero (int numero)
    {
       this.numero = numero;
    }
     protected int Getnumero ()
    {
       return numero;
    }
    //_______________________________________
     protected void SetValor (string Valor)
    {
       this.Valor = Valor;
    }
     protected string GetValor ()
    {
       return Valor;
    }
    //______________________________________
     protected void Setpercurçopercorrido (string percurçopercorridod)
    {
       this.percurçopercorrido = percurçopercorridod;
    }
     protected string Getpercurçopercorrido ()
    {
       return percurçopercorrido;
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