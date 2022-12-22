using System;
using System.Collections.Generic;
using System.Text;

namespace AutoHero.WPF.CEF.Events
{
    /// <summary>
    /// CEF 프로젝트는 AutoHero의 모든 api에 접근할 수 있어야한다.
    /// </summary>
    public interface IEventRegister
    { 
        public CefSharp.BindingOptions binder { get; }
    }
}
