using System;
using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class TempodeProducao : ContentPage
    {
        public TempodeProducao()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Handle Voltar button click
            // For example, Navigation.PopAsync();
            Navigation.PopAsync();
        }
    }
}
