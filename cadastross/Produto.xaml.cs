using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class Produto : ContentPage
    {
        public Produto()
        {
            InitializeComponent();
        }
        	private void botâoVoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }

    }
}
