using System.Windows.Input;

namespace mpad
{
    public static class Keydowns
    {
        public static bool save_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.S) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.S);
        }

        public static bool saveAs_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.S) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.RightShift) && Keyboard.IsKeyDown(Key.S);
        }

        public static bool open_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.O) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.O);
        }

        public static bool new_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.N) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.N);
        }

        public static bool autoSave_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.U) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.U);
        }

        public static bool themeSet_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.Y) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.Y);
        }

        public static bool zoomIn_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.OemPlus) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.OemPlus);
        }

        public static bool zoomOut_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.OemMinus) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.OemMinus);
        }

        public static bool find_keyDown()
        {
            return Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.F) || Keyboard.IsKeyDown(Key.RightCtrl) && Keyboard.IsKeyDown(Key.F);
        }
    }
}
