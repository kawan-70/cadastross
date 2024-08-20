using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class Transportadora : ContentPage
    {
        public Transportadora()
        {
            InitializeComponent();
        }
            private void ovoltei(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }
    }
}
