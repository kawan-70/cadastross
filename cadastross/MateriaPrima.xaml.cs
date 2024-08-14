using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class MateriaPrima : ContentPage
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }
           private void botâoVoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }
    }
}

