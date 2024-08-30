using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace cadastross
{
public partial class CadastroCliente : ContentPage
    {

        Cliente cliente;

        ClienteControle clienteControle;
        public CadastroCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            clienteControle = new ClienteControle();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                IdLabel.Text = cliente.Id.ToString();

                Name.Text = cliente.Nome;

                cpfEntry.Text = cliente.Cpf;

                endereçoEntry.Text = cliente.Endereço;

                GmailEntry.Text = cliente.Gmail;

            }
        }

        private void DeleteCliente(object sender, EventArgs e)
        {
            IdLabel.Text = string.Empty;

            Name.Text = string.Empty;

            cpfEntry.Text = string.Empty;
            
            endereçoEntry.Text = string.Empty;

            GmailEntry.Text = string.Empty;
        }

        private async void SalvarCliente(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var cliente = new Modelos.Cliente();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.Id = int.Parse(IdLabel.Text);
                else
                cliente.Id = 0;
                cliente.Nome = Name.Text;

                cliente.Cpf = cpfEntry.Text;

                cliente.Endereço = endereçoEntry.Text;

                clienteControle.CriarEAtualizar(cliente);
            }
            await DisplayAlert("Salvar", "Dados Salvos!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(Name.Text))
            {
                await DisplayAlert("Cadastrar", "o campo nome ainda esta embranco, preencha!", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(cpfEntry.Text))
            {
                await DisplayAlert("Cadastrar", "o campo cpf ainda esta em branco, preencha!", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(endereçoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo endereço é obrigatório, Preencha!", "OK");
                return false;
            }
            else
                return true;
        }


        private async void Exluircancela(object sender, EventArgs e)  
        {
            if (cliente == null || cliente.Id < 1)
               await DisplayAlert("Ops, Erro", "não a dados do cliente para excluir", "ok");
            else if (await DisplayAlert("Excluir","cliente sera excluido, tem certeza?","Excluir Cliente","cancelar"))
            {
                clienteControle.Apagar(cliente.Id);

                 Application.Current.MainPage = new TeladoCliente();                 
            }

            
        }


    }

}