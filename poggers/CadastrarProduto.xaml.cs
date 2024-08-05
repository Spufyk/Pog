using System;
using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class CadastrarProduto : ContentPage
    {
        public CadastrarProduto()
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
            // Implement product registration logic
        }
    }
}
