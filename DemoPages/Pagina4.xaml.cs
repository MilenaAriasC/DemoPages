using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPages
{
    public partial class Pagina4 : ContentPage
    {
        public Pagina4()
        {
            InitializeComponent();
            btncerrar.Clicked += Btncerrar_Clicked;
        }

       private void Btncerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}
