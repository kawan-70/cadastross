using Microsoft.Maui.Controls;

namespace cadastross
{
    public partial class Fornecedor : ContentPage
    {
        public Fornecedor()
        {
            InitializeComponent();
        }
           private void heijavoltei(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }

        private void cadastrarfornecedor(object sender, EventArgs args)
	{
		Application.Current.MainPage = new CadastroFornecedor();
    }
    }
}
