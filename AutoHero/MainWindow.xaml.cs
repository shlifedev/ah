using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.SchemeHandler;
using AutoHero.CEF;

namespace AutoHero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeChromium();
        }

        /// <summary>
        /// 크로미움 객체생성
        /// </summary>
        public void InitializeChromium()
        {
            var settings = new CefSettings();
            AutoHero.CEF.Browser.Create(browserContainer);
        }
    }
}
