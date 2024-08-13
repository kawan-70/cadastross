using LiteDB;

namespace Modelos;

public class Materia : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Tempodeproduçâo { get; set; }
  public string Quantidade { get; set; }
}