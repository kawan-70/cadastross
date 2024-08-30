using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class CadastroTransportadora : ContentPage

 
    {
        public CadastroTransportadora()
        {
            InitializeComponent();
        }
        
      private void transportadora(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Transportadora();
    }
    private void volteitela(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }
    }
}