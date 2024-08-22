using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class TeladoCliente : ContentPage
    {
        public TeladoCliente()
        {
            InitializeComponent();
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