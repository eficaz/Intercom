using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
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
                entryURL.Text = "https://camppro.eficaztechsol.com/home/index/Megha/123456";

                LoadWebPage();

            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        public  void LoadWebPage()
        {
            ShowProgress(true);
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<html>
                <head>
   
                    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
                </head>
                <body >
                    <a href='#' onclick=Intercom('show')>
               
                        <button id='btn' onclick='test()' style='visibility:hidden;'>Click me</button>
                </body>
                <script>
                    var username = 'Megha';
                    var userid = '123456';

                    function test() {
                        window.intercomSettings = {
                            app_id: 'mm945018',
                            custom_launcher_selector: '#btn',
                            user_id: userid,
                            name: username
                        };

                    }

                    window.onload = function () {
                        document.getElementById('btn').click();

                        var scriptTag = document.createElement('script');
                        scriptTag.src = 'https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js';
                        document.getElementsByTagName('head')[0].appendChild(scriptTag);


                    }
                    $(document).ready(function () {

                        $('.intercom-messenger-header-buttons-back-button').trigger('click');
                    });

                    window.intercomSettings = {
                        app_id: 'mm945018',
                        alignment: 'left',
                        horizontal_padding: 20,
                        vertical_padding: 20,
                        custom_launcher_selector: '#btn',
                        name: username,
                        user_id: userid
                    };
                </script>

                <script>
                    // We pre-filled your app ID in the widget URL: 'https://widget.intercom.io/widget/mm945018'
                    (function () {
                        var w = window;
                        var ic = w.Intercom;
                        if (typeof ic === 'function') {
                            ic('reattach_activator');
                            ic('update', w.intercomSettings);

                        } else { var d = document; var i = function () { i.c(arguments); }; i.q = []; i.c = function (args) { i.q.push(args); }; w.Intercom = i; var l = function () { var s = d.createElement('script'); s.type = 'text/javascript'; s.async = true; s.src = 'https://widget.intercom.io/widget/mm945018'; var x = d.getElementsByTagName('script')[0]; x.parentNode.insertBefore(s, x); }; if (w.attachEvent) { w.attachEvent('onload', l); } else { w.addEventListener('load', l, false); } }
                    })();
                </script>
                </html>";
            myWebView.Source = htmlSource;
            Content = myWebView;

        }

        private void EntryURL_Completed(object sender, EventArgs e)
        {
            //ShowProgress(true);
            LoadWebPage();
        }

        private void MyWebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            ShowProgress(true);
            entryURL.Text = "https://camppro.eficaztechsol.com/home/index/Megha/123456";
            LoadWebPage();


        }

      

        private void MyWebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            entryURL.Text = "https://camppro.eficaztechsol.com/home/index/Megha/123456";
            ShowProgress(false);
            
        }
        public void ShowProgress(Boolean show)
        {
            activityIndicator.IsVisible = show;
            activityIndicator.IsRunning = show;

        }



    }
}