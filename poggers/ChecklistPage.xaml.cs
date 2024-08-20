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
           Application.Current.MainPage = new TeladeInicio();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Ação para o botão Salvar
            bool produtoX = ProdutoXCheckBox.IsChecked;
            bool produtoY = ProdutoYCheckBox.IsChecked;
            bool produtoW = ProdutoWCheckBox.IsChecked;
            bool produtoZ = ProdutoZCheckBox.IsChecked;

            // Lógica para salvar os dados do checklist
            // Aqui você pode adicionar a lógica para salvar os estados dos CheckBox
        }
    }
}
