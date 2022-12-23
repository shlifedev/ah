using System.Diagnostics;
using System.Numerics;

namespace AutoHero.InputHelper
{
    public interface IController
    { 
        void KeyDown(int keycode);
        void KeyUp(int keycode);
        /// <summary>
        /// down, up 합성이벤트
        /// </summary>
        /// <param name="keycode"></param>
        void KeyPress(int keycode);
        void MoveMouse(Vector2 dir);
        void MoveMouseDirect(Vector2 dir);
        void MouseDown(int key);
        void MouseUp(int key);
        /// <summary>
        /// 현재 커서 위치에서 클릭
        /// </summary>
        /// <param name="keycode"></param>
        void MouseClick(int key);
        /// <summary>
        /// 지정된 좌표에서 클릭
        /// </summary>
        /// <param name="keycode"></param>
        void MouseClick(int key, Vector2 position);
        void MouseDoubleClick(int key);
        void MouseDoubleClick(int key, Vector2 position);

        /// <summary>
        /// 드래그
        /// </summary> 
        void MouseDrag(int key, Vector2 start, Vector2 end, float second);

    }

}