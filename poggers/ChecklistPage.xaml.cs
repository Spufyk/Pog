using System;
using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class ChecklistPage : ContentPage
    {
        public ChecklistPage()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Handle Voltar button click
            // For example, Navigation.PopAsync();
            Navigation.PopAsync();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Handle Salvar button click
            // Implement save logic
        }
    }
}
