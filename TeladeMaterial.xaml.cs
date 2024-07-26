using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace SeuApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Simulando dados da lista
            ListaDeMateriais = new List<string>
            {
                "Linhas",
                "Plástico",
                "Botão",
                "Agulhas"
            };

            BindingContext = this;
        }

        public List<string> ListaDeMateriais { get; set; }
    }
}
