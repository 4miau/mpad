using System;
using System.IO;
using System.Windows.Forms;
using static mpad.Settings;

namespace mpad
{
    static class App
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(configPath) || !File.Exists(configPath + @"\mpad.json"))
            {
                Directory.CreateDirectory(configPath);

                mpadJSON defaultConfig = new mpadJSON { id = 1, theme = "Light", wrap = true, font = "Segoe UI", saveTimer = 30000, fontSize = 12f };
                SerializeConfig(defaultConfig);
            }

            DeserializeConfig();

            if (!File.Exists(fontSizePath))
            {
                File.CreateText(fontSizePath);
                using (StreamWriter sw = new StreamWriter(fontSizePath))
                {
                    sw.Write("2, 3, 4, 6, 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 44, 48, 52, 56, 60, 66, 72, 80, 88, 96, 108, 120, 132, 144, 168");
                }
            }

            mpadMain newMain = new mpadMain();
            newMain.Activate();

            Application.Run(newMain);
        }
    }
}