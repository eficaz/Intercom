using Intercomapp.CustomControls;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intercomapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewbotPage : ContentPage
    {
        private string UserName { get; set; }
        private string UserEmail { get; set; }
        private string IntercomAppId { get; } = "mm945018";

        public NewbotPage(string userName, string userEmail)
        {
            UserName = userName;
            UserEmail = userEmail;
            InitializeComponent();
        }
        public void LoadWebPage()
        {
            
            var browser = new WebView();          
            browser.Source = "https://camppro.eficaztechsol.com/home/test";
            Content = browser;

        }
        protected override void OnAppearing()
        {
            LoadWebPage();
        }

       
    private async void sendData()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                LandingPage newpage = new LandingPage();
                Navigation.PushAsync(new LandingPage());
            });
           
        }

    }
}