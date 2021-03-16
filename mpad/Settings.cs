using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace mpad
{
    class Settings
    {
        internal class mpadJSON
        {
            public int id;
            public string theme;
            public bool wrap;
            public string font;
            public int saveTimer;
            public float fontSize;
        }

        internal static readonly string configPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\mpad";
        internal static readonly string fontSizePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\mpad\fontSizes.txt";
        internal static readonly mpadJSON impConfig = new mpadJSON();


        static void SetConfiguration(mpadJSON json)
        {
            impConfig.id = json.id;
            impConfig.theme = json.theme;
            impConfig.wrap = json.wrap;
            impConfig.font = json.font;
            impConfig.saveTimer = json.saveTimer;
            impConfig.fontSize = json.fontSize;
        }

        internal static void DeserializeConfig()
        {
            string jsonObject = "";
            
            using (FileStream fs = new FileStream(configPath + @"\mpad.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs, Encoding.Default)) jsonObject = sr.ReadToEnd();

            mpadJSON configJson = JsonConvert.DeserializeObject<mpadJSON>(jsonObject);
            SetConfiguration(configJson);
        }


        internal static void SerializeConfig(mpadJSON currentConfig)
        {
            string exportString = JsonConvert.SerializeObject(currentConfig);
            
            using (FileStream fs = new FileStream(configPath + @"\mpad.json", FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.Default)) sw.Write(exportString);
        }
    }
}