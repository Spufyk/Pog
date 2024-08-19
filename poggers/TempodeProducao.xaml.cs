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

        void OnVoltarClicked(object sender, EventArgs e)  
        {
        Application.Current.MainPage = new TeladeInicio();
        }   
    }
}
