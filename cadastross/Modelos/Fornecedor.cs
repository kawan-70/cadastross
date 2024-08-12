using cadastross;

namespace cadastross.Modelos;

public class Fornecedor : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Endereço { get; set; }
  public string Numero { get; set; }
  public string Cpf { get; set; }
  public string Estado { get; set; }
}