using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Intercomapp.ViewModels;
using Intercomapp.Views;
using Xamarin.Forms;

namespace Intercomapp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }
        protected async override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == "CurrentItem")
            {
                int index = this.Items.IndexOf(this.CurrentItem);
                if (index == 0)
                {
                    AboutPage page2 = new AboutPage();
                    await Navigation.PushAsync(page2);
                }

            }
        }
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
        private async void OnContact1ItemClicked(object sender, EventArgs e)
        {
           
            AboutPage page2 = new AboutPage();
            await Navigation.PushAsync(page2);
        }
    }
}
