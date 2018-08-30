using System;

using Xamarin.Forms;

namespace DemoPages
{
    public class Detalle : ContentPage
    {
        public Detalle()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

