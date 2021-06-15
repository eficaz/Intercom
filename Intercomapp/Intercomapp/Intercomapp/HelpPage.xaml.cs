using Intercomapp.CustomControls;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intercomapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelpPage : ContentPage
    {
        private string UserName { get; set; }
        private string UserEmail { get; set; }
        private string IntercomAppId { get; } = "mm945018";

        public HelpPage(string userName, string userEmail)
        {
            UserName = userName;
            UserEmail = userEmail;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var sb = new StringBuilder();
            sb.Clear();
            sb.AppendLine($"<html><head><script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script></head>");
            sb.AppendLine($"<body></body>");
            sb.AppendLine($"<script>");
            //sb.AppendLine($"window.onload = function () {{  ;Intercom('show'); }}");
            sb.AppendLine($"window.onload = function () {{ Intercom('onHide',function() {{  invokeCSharpAction();}}) ;Intercom('show'); }}");
            //sb.AppendLine($"$(document).ready(function () {{$('.intercom-messenger-header-buttons-back-button').trigger('click');}});");
            sb.AppendLine($"window.intercomSettings = {{");
            sb.AppendLine($"    app_id: '{IntercomAppId}',");
            sb.AppendLine($"    alignment: 'center',");
            sb.AppendLine($"    horizontal_padding: 0,");
            sb.AppendLine($"    vertical_padding: 0,");
            sb.AppendLine($"    hide_default_launcher: true,");
            sb.AppendLine($"    name: '{UserName}',");
            sb.AppendLine($"    user_id: '{UserEmail}',");
            sb.AppendLine($"    email: '{UserEmail}',");sb.AppendLine($"    apples: '1',");
            sb.AppendLine($"}};");
            sb.AppendLine($"</script>");
            sb.AppendLine($"<script>");
            sb.AppendLine($"    (function () {{");
            sb.AppendLine($"        var w = window;");
            sb.AppendLine($"        var ic = w.Intercom;");
            sb.AppendLine($"        if (typeof ic === 'function') {{");
            sb.AppendLine($"            ic('reattach_activator');");
            sb.AppendLine($"            ic('update', w.intercomSettings);");
            sb.AppendLine($"        }} else {{ var d = document; var i = function () {{ i.c(arguments); }}; i.q = []; i.c = function (args) {{ i.q.push(args); }}; w.Intercom = i; var l = function () {{ var s = d.createElement('script'); s.type = 'text/javascript'; s.async = true; s.src = 'https://widget.intercom.io/widget/{IntercomAppId}'; var x = d.getElementsByTagName('script')[0]; x.parentNode.insertBefore(s, x); }}; if (w.attachEvent) {{ w.attachEvent('onload', l); }} else {{ w.addEventListener('load', l, false); }} }}");
            sb.AppendLine($"    }})();");
            sb.AppendLine($"</script>");
            sb.AppendLine($"</html>");

            var hybridWebView = new HybridWebView
            //var hybridWebView = new WebView
            {
                Source = new HtmlWebViewSource { Html = sb.ToString() },
            };

            // hybridWebView.RegisterAction(data => DisplayAlert("Alert", "dddd " + data, "OK"));
            hybridWebView.RegisterAction(data => sendData());
           
            Content = hybridWebView;
            
            base.OnAppearing();
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