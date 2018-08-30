using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPages
{
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
            this.btninicial.Clicked += Btninicial_Clicked;
            this.btnatras.Clicked += Btnatras_Clicked;
            this.btnmodal.Clicked += Btnmodal_Clicked;
        }

        private async void Btninicial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

         private async void Btnatras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

         private async void Btnmodal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pagina4());  
        }

    }
}
