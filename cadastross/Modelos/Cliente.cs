using LiteDB;

namespace Modelos;

public class Cliente : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Gmail { get; set; }
  public string Cpf { get; set; }
  public string Endereço { get; set; }
}
// <Button Text="digite seu nome"
//                           FontSize="20"
//                           BackgroundColor="#5c67e0"
//                           Margin="0,5"
//                           HorizontalOptions="FillAndExpand"/>
//
//                   <Button Text="digite seu nome"
//                           FontSize="20"
//                           BackgroundColor="#5c67e0"
//                           Margin="0,5"
//                           HorizontalOptions="FillAndExpand"/>
//
//                    <Button Text="digite seu nome"
//                           FontSize="20"
//                            BackgroundColor="#5c67e0"
//                           Margin="0,5"
//                           HorizontalOptions="FillAndExpand"/>
//
//                    <Button Text="digite seu nome"
//                            BackgroundColor="#5c67e0"
//                            FontSize="20"
//                            Margin="0,5"
//                            HorizontalOptions="FillAndExpand"/>
//               </StackLayout>