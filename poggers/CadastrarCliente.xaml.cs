using System;
using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class CadastrarCliente : ContentPage
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Handle Voltar button click
            // For example, Navigation.PopAsync();
            Navigation.PopAsync();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Handle Confirmar button click
            // Implement registration logic
        }
    }
}
