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
            Application.Current.MainPage = new TeladeInicio();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            //nada
        }
    }
}
