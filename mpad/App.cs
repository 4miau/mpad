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

                mpadJSON defaultConfig = new mpadJSON
                    {id = 1, theme = "Light", wrap = true, font = "Segoe UI", saveTimer = 30000, fontSize = 12f};
                SerializeConfig(defaultConfig);
            }

            DeserializeConfig();

            mpadMain newMain = new mpadMain();
            newMain.Activate();

            Application.Run(newMain);
        }
    }
}