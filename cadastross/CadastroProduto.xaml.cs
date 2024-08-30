using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class CadastroProduto : ContentPage

 
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }
        
      private void telaproduto(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Produto();
    }
    }
}