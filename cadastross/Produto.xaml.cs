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
      private void botâocadastrar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new CadastroCliente();
    }

 private void cadastroP(object sender, EventArgs args)
	{
		Application.Current.MainPage = new CadastroProduto();
    }
    }
}
