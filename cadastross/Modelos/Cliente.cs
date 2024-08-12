using cadastross;

namespace cadastross;

public class Cliente : Pessoas
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Gmail { get; set; }
  public string Cpf { get; set; }
  public string Endereço { get; set; }
}