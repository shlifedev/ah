using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AutoHero.InputHelper
{
    internal class InputHelper
    {
        private IController controller; 
        /// <summary>
        /// 타겟이 없을경우 null, 컨트롤러에 따라 상이
        /// </summary>
        private Process target;

        public InputHelper(IController controller, Process target)
        {
            this.controller = controller;
            this.target = target; 
        }

        public IController GetController() => controller;
    }
}
