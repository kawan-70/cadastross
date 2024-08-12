using cadastross;

namespace cadastross.Modelos;

public class Transportadora : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Endereço { get; set; }
  public string Numero { get; set; }
  public string Valor { get; set; }
  public string PercurçoPercorrido { get; set; }
  public string Cidade { get; set; }
  public string Estado { get; set; }
}