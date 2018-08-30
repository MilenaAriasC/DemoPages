using System;

using Xamarin.Forms;

namespace DemoPages
{
    public class DemoCarouselPage : ContentPage
    {
        public DemoCarouselPage()
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

