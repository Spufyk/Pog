using System;
using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class ClientesPage : ContentPage
    {
        public ClientesPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarNovoClicked(object sender, EventArgs e)
        {
            // Handle Cadastrar Novo button click
            // For example, Navigation.PushAsync(new CadastrarClientePage());
            Navigation.PushAsync(new CadastrarClientePage());
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Handle Voltar button click
            // For example, Navigation.PopAsync();
            Navigation.PopAsync();
        }
    }
}
