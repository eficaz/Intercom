using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Intercomapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private async void Help1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage(Name1.Text,Email1.Text));
        }

        private async void Help2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage(Name2.Text, Email2.Text));
        }

        private async void Newbot_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewbotPage(Name1.Text, Email1.Text));
        }
    }
}