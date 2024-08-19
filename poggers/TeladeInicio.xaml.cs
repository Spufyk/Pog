using System;
using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class TeladeInicio : ContentPage
    {
        public TeladeInicio()
        {
            InitializeComponent();
        }
        
        // Add event handlers for buttons if needed
        private void OnTelaChecklistClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ChecklistPage();
        }
        
        private void OnTelaTempodeProducaoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TempodeProducao();
        }
        
        private void OnTelaClienteClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ClientesPage();
        }
        
        private void OnTelaProdutoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Produto();
        }
    }
}