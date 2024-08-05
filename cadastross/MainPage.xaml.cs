using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
	private void botãoproduto(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Produto();
    }
}
}