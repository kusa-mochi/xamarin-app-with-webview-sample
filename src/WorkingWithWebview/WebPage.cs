using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();
            browser.Source = "file:///android_asset/index.html";
            Content = browser;
        }
    }
}

