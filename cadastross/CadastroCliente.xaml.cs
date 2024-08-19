using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class CadastroCliente : ContentPage
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