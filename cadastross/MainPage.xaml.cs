using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
	private void botãoproduto(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Produto();
    }
    	private void botãocliente(object sender, EventArgs args)
	{
		Application.Current.MainPage = new TeladoCliente();
    }
    	private void botãoMateria(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MateriaPrima();
    }
    	private void botãoTransportadora(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Transportadora();
    }
    	private void botãoFornecedor(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Fornecedor();
    }
}
}