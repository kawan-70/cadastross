using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class TeladoCliente : ContentPage
    {
        public TeladoCliente()
        {
            InitializeComponent();
        }
        private void botâoVoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }
    }
}