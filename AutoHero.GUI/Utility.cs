using CefSharp.SchemeHandler;
using CefSharp.Wpf;
using CefSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AutoHero.CEF
{
    public static class Utility
    {
        public static void InitializeBrowserToGrid(ContentControl control)
        {
            var settings = new CefSettings();

            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "localfolder",
                DomainName = "cefsharp",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                    rootFolder: @"C:\Users\shlif\source\repos\AutoHero\AutoHero\bin\Debug\netcoreapp3.1\frontend",
                    hostName: "cefsharp",
                    defaultPage: "index.html" // will default to index.html
                )
            });

            Cef.Initialize(settings);

            ChromiumWebBrowser browser = new ChromiumWebBrowser()
            {
                Address = "http://www.google.com"
            };
            var htmls = System.IO.File.ReadAllText("./frontend/index.html");
            browser.LoadHtml(htmls);
            control.Content = browser;
        }
    }
}
