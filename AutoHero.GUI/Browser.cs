using CefSharp.SchemeHandler;
using CefSharp.Wpf;
using CefSharp; 
using System.Windows.Controls; 
using System.IO;
using System.Windows; 
using CefSharp.JavascriptBinding;

namespace AutoHero.CEF
{
    public static class Browser
    {
        /// <summary>
        /// 기본참조 index 파일
        /// </summary>
        public static string BasePath => $@"gui\index.html";
        private static ChromiumWebBrowser browser;

        public static ChromiumWebBrowser GetBrowser() => browser;

        public static ChromiumWebBrowser Create(ContentControl control)
        { 
            if (control != null)
            {
                var settings = new CefSettings();
                settings.Locale = "ko"; 
                settings.RemoteDebuggingPort = 1234;
            


                Cef.Initialize(settings);
                var fi = new FileInfo(BasePath); 
                if (fi.Exists)
                {
                    browser = new ChromiumWebBrowser();
                    // JS 객체등록

                    browser.JavascriptObjectRepository.NameConverter = new CefSharp.JavascriptBinding.CamelCaseJavascriptNameConverter();
                    browser.JavascriptObjectRepository.ResolveObject += (sender, e) =>
                    { 
                        var repo = e.ObjectRepository;  
                        repo.Register(e.ObjectName, new AutoHero.CEF.Events.MessageBox(), BindingOptions.DefaultBinder);
                    };
                    // 개발자 도구
                    browser.IsBrowserInitializedChanged += (s, e) =>
                    { 
                        browser.ShowDevTools();
                    }; 
                    browser.LoadUrl(@$"file://{fi.FullName}");
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
