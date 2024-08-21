using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class CadastroCliente : ContentPage

//    public Cliente cliente { get; set; }
//  Controles.ClienteControle clienteControle = new Controles.ClienteControle();
//  Controles.EstadoControle estadoControle = new Controles.EstadoControle();
 
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }
        
      private void todevolta(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Produto();
    }
    }
}