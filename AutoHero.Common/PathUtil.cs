using System;
using System.Collections.Generic;
using System.Text;

namespace AutoHero.Common
{
    public static class PathUtil
    {
        public static string GetCurrentDirectory() => System.AppDomain.CurrentDomain.BaseDirectory;
    }
}
