using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yondr_Finance.Views;


[assembly: ExportFont("SuisseIntl-Black.otf", Alias = "Black-succi")]
[assembly: ExportFont("SuisseIntl-Bold.otf", Alias = "Bold-succi")]
[assembly: ExportFont("SuisseIntl-Book.otf", Alias = "Book-succi")]
[assembly: ExportFont("SuisseIntl-Light_0.otf", Alias = "Light-succi")]
[assembly: ExportFont("SuisseIntl-Regular.otf", Alias = "Regular-succi")]
[assembly: ExportFont("SuisseIntl-SemiBold.otf", Alias = "Semibold-succi")]


namespace Yondr_Finance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            base.OnAppLinkRequestReceived(uri);
            if (uri.Host.ToLower() == "yondr" && uri.Segments != null && uri.Segments.Length == 2)
            {
                string action = uri.Segments[1].Replace("/", "");
               // bool isActionParamsValid = long.TryParse(uri.Segments[2], out long productId);
                if (action.ToLower() == "signup" )
                {
                    
                        // Navigate to you product details page.
                        App.Current.MainPage = new NavigationPage(new EmailPage());
                       
                   
                    
                }
                else
                {
                    // it can be security attack => navigate to home page or login page.
                    App.Current.MainPage = new NavigationPage(new HomePage());

                }
            }
        }
    }
}
