using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class TeladoCliente : ContentPage
    {
          Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public TeladoCliente()
        {
            InitializeComponent();
            ListaClientes.ItemsSource = clienteControle.LerTodos();
        }
        private void outodevolta(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }

       private void cadastrar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new CadastroCliente();
    }

         

      

    }
}