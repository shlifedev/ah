using AutoHero.WPF.CEF.Events;
using CefSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AutoHero.CEF.Events
{ 
    public class MessageBox  
    { 
        public MessageBoxShowResponse Show(MessageBoxShowRequest request)
        {
            if (request == null)
            {
                return new MessageBoxShowResponse { Success = false };
            }

            System.Windows.MessageBox.Show(request.Message.ToString()); 
            return new MessageBoxShowResponse { Success = true };
        }
    }

    public class MessageBoxShowRequest
    {
        public int Message { get; set; }
    }

    public class MessageBoxShowResponse
    {
        public bool Success { get; set; } 
    }

}
