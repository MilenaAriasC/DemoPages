using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPages
{
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
            this.loption.Text = string.Empty;
            btntres.Clicked += Btntres_Clicked;
        }

        private async void Btntest_Clicked(object sender, System.EventArgs e)
        {
            this.loption.Text = string.Empty;
            var resp = await DisplayAlert("Test","Esta seguro de realizar el Test", "Si","No");
            if(resp){
                await DisplayAlert("Inicio de Test","super bienvenido","Aceptar");
                var opcion = await DisplayActionSheet("Opciones","Cancelar", null,"Opcion 1", "Opcion 2", "Opcion 3");
                loption.Text = opcion.ToString();
            }
            else{
                await DisplayAlert("Test Fallido", "En otra ocacion sera", "Aceptar");
            }
        }

        private async void Btntres_Clicked(object sender, EventArgs e)
        {
            this.loption.Text= string.Empty;
            await Navigation.PushAsync(new Pagina3());
        }

    }
}
