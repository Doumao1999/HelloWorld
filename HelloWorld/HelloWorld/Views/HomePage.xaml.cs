using System;
using Xamarin.Forms;

namespace HelloWorld.Views
{
    public partial class HomePage : ContentPage
    {

        public HomePage()
        {
            InitializeComponent();
        }

        
        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelloPage());
        }

    }
}
