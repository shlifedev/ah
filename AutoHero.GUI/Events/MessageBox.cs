using AutoHero.WPF.CEF.Events;
using CefSharp;
using CefSharp.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AutoHero.CEF.Events
{ 
    public class MessageBox  : IEventRegister
    {
        public BindingOptions binder => BindingOptions.DefaultBinder;

        public bool Show(string message)
        {
            return System.Windows.MessageBox.Show(message) == MessageBoxResult.OK; 
        }
    }
      
}
