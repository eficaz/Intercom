using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intercomapp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            ShowProgress(true);
            if (myWebView.CanGoBack)
                myWebView.GoBack();
            else
            {
                entryURL.Text = "https://camppro.eficaztechsol.com/";
                LoadWebPage();

            }
        }

        private void EntryURL_Completed(object sender, EventArgs e)
        {
            //ShowProgress(true);
            LoadWebPage();
        }

        private void MyWebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            ShowProgress(true);
            entryURL.Text = e.Url.ToString();
        }

        private void BtnLoad_Clicked(object sender, EventArgs e)
        {
            LoadWebPage();
        }

        public void LoadWebPage()
        {
            ShowProgress(true);
            if (entryURL.Text != null && !entryURL.Text.ToString().Trim().Equals(""))
                myWebView.Source = new UriBuilder(entryURL.Text.ToString()).Uri;
        }

        private void MyWebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            entryURL.Text = e.Url.ToString();
            ShowProgress(false);
        }

        public void ShowProgress(Boolean show)
        {
            activityIndicator.IsVisible = show;
            activityIndicator.IsRunning = show;

        }
    }
}