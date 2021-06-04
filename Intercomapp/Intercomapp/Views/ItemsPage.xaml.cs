using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Intercomapp.Models;
using Intercomapp.Views;
using Intercomapp.ViewModels;

namespace Intercomapp.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();
            ShowProgress(true);
            if (myWebView.CanGoBack)
                myWebView.GoBack();
            else
            {
                entryURL.Text = "https://camppro.eficaztechsol.com/home/requestinfo";
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