using Microsoft.Maui.Controls;

namespace poggers
{
    public partial class AtualizarProduto : ContentPage
    {
        public AtualizarProduto()
        {
            InitializeComponent();
        }

        private void VoltarButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TeladeInicio();
        }

        private void AtualizarButton_Clicked(object sender, EventArgs e)
        {
            // Lógica para o botão Atualizar
        }

        private void UploadButton_Clicked(object sender, EventArgs e)
        {
            //nada
        }
    }
}
