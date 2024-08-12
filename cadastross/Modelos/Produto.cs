using cadastross;

namespace cadastross.Modelos;

public class Produto : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Bairronoufação { get; set; }
  public string Tempoestimado { get; set; }
  public string Valor { get; set; }
  public string Quantidade { get; set; }
}