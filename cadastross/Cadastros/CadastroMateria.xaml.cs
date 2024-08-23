using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class CadastroMateria : ContentPage

//    public Cliente cliente { get; set; }
//  Controles.ClienteControle clienteControle = new Controles.ClienteControle();
//  Controles.EstadoControle estadoControle = new Controles.EstadoControle();
 
    {
        public CadastroMateria()
        {
            InitializeComponent();
        }
        
      private void materia(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MateriaPrima();
    }
    private void todevolta(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MateriaPrima();
    }
    }
}