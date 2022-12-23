using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using WindowsInput;

namespace AutoHero.InputHelper
{
    public class WinAPIController : IController
    {
        public WinAPIController(Process process)
        {
             
            Process = process;
            simulator = new InputSimulator();
        }

        InputSimulator simulator;
        public Process Process { get; set; }

        [DllImport("user32.dll")]
        public static extern int PostMessage(int hwnd, int wMsg, int wParam, int lParam);

        public void KeyDown(int keycode)
        {
          
        }

        public void KeyPress(int keycode)
        {
            throw new System.NotImplementedException();
        }

        public void KeyUp(int keycode)
        {
            throw new System.NotImplementedException();
        }

        public void MouseClick(int key)
        {
            throw new System.NotImplementedException();
        }

        public void MouseClick(int key, Vector2 position)
        {
            throw new System.NotImplementedException();
        }

        public void MouseDoubleClick(int key)
        {
            throw new System.NotImplementedException();
        }

        public void MouseDoubleClick(int key, Vector2 position)
        {
            throw new System.NotImplementedException();
        }

        public void MouseDown(int key)
        {
            throw new System.NotImplementedException();
        }

        public void MouseDrag(int key, Vector2 start, Vector2 end, float second)
        {
            throw new System.NotImplementedException();
        }

        public void MouseUp(int key)
        {
            throw new System.NotImplementedException();
        }

        public void MoveMouse(Vector2 dir)
        {
            throw new System.NotImplementedException();
        }

        public void MoveMouseDirect(Vector2 dir)
        {
            throw new System.NotImplementedException();
        }

    }

}