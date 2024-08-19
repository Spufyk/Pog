using System;
using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class AtualizarCliente : ContentPage
    {
        public AtualizarCliente()
        {
            InitializeComponent();
        }

        // Add event handlers for buttons if needed
        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TeladeInicio();
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
           //nada
        }
    }
}
