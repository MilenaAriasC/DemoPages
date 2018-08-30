using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPages
{
    public partial class DemoNavigationPage : ContentPage
    {
        
        public DemoNavigationPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Pagina2());
        }
    }
}
