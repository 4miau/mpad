using Newtonsoft.Json;
using System;
using System.IO;

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

            using (StreamReader sr = new StreamReader(configPath + @"\mpad.json"))
            {
                jsonObject = sr.ReadToEnd();
            }

            mpadJSON configJson = JsonConvert.DeserializeObject<mpadJSON>(jsonObject);

            SetConfiguration(configJson);
        }


        internal static void SerializeConfig(mpadJSON currentConfig)
        {

            string exportString = JsonConvert.SerializeObject(currentConfig);


            using (StreamWriter sw = new StreamWriter(configPath + @"\mpad.json")) sw.Write(exportString);
        }
    }
}

/*
 * Serialize Idea:
 - Boolean Argument of Default on method SerializeConfig
 - Switch Case if false, get the config of the mpad session and save (usually when exiting)
 - Switch Case if true, serialize the default config for the set config
 */