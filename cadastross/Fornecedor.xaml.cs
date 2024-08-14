using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class Fornecedor : ContentPage
    {
        public Fornecedor()
        {
            InitializeComponent();
        }
           private void botâoVoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }
    }
}
