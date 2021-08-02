using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intercomapp.Views
{
  
    public partial class FaqPage : ContentPage
    {
        public FaqPage()
        {
            InitializeComponent();
            Webview.Source = "https://intercom.help/yondr-money/en";
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.9, 900, Easing.SpringIn);
        }

        protected void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
        }

        protected void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
        }



    }
}