using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoPages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Btn1_Clicked(object sender, System.EventArgs e)
        {
            panel.Children.Add(new Button()
            {
                Text = $"boton{panel.Children.Count + 1}"
            });

        }
    }
}
