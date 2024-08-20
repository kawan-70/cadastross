using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class MateriaPrima : ContentPage
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }
           private void botaotodevolta(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }
    }
}

