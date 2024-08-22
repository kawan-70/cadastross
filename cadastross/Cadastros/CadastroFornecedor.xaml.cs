using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class CadastroFornecedor : ContentPage

//    public Cliente cliente { get; set; }
//  Controles.ClienteControle clienteControle = new Controles.ClienteControle();
//  Controles.EstadoControle estadoControle = new Controles.EstadoControle();
 
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }
        
      private void fornecedor(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Fornecedor();
    }
    }
}