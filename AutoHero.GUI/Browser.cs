using CefSharp.SchemeHandler;
using CefSharp.Wpf;
using CefSharp; 
using System.Windows.Controls; 
using System.IO;
using System.Windows; 
using CefSharp.JavascriptBinding;
using System.Runtime.InteropServices;
using System;

namespace AutoHero.CEF
{
    public static class Browser
    { 
        public static string BasePath => $@"gui\index.html";
        private static ChromiumWebBrowser browser;

        public static ChromiumWebBrowser GetBrowser() => browser;
        static class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AllocConsole();
        } 
        public static ChromiumWebBrowser Create(ContentControl control)
        {
            NativeMethods.AllocConsole();
            if (control != null)
            {
                var settings = new CefSettings();
                settings.Locale = "ko"; 
                settings.RemoteDebuggingPort = 1234; 
                settings.CachePath = AppDomain.CurrentDomain.BaseDirectory + "/cache";
                Cef.Initialize(settings);
                var fi = new FileInfo(BasePath); 
                if (fi.Exists)
                {
                    browser = new ChromiumWebBrowser(); 
                    browser.JavascriptObjectRepository.NameConverter = new CamelCaseJavascriptNameConverter(); 
                    browser.JavascriptObjectRepository.ResolveObject += (sender, e) =>
                    { 
                        var repo = e.ObjectRepository;
                        repo.NameConverter = null;
                        repo.NameConverter = new CamelCaseJavascriptNameConverter(); 
                        repo.Register(e.ObjectName, new AutoHero.CEF.Events.MessageBox(), BindingOptions.DefaultBinder);
                    };
                    // 개발자 도구
                    browser.IsBrowserInitializedChanged += (s, e) =>
                    { 
                        browser.ShowDevTools();
                    };
                    browser.LoadUrl(@$"file://{fi.FullName}");
                    browser.LoadUrl(@$"http://localhost:3000");
                    control.Content = browser;  
                    return browser; 
                }
                else
                {
                    control.Content = "GUI Initialize Failed";
                    return null;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("GUI 초기화에 실패했습니다.", "초기화 실패", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        } 
    }
}
