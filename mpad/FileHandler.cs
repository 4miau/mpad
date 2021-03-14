using System.IO;
using Guna.UI2.WinForms;

namespace mpad
{
    public static class FileHandler
    {
        public static void EmergencyRecovery(Guna2TextBox txtMain, string EmergencyPath)
        {
            if (!Directory.Exists(EmergencyPath))
                Directory.CreateDirectory(EmergencyPath);

            string filename = Anti_Overwrite(EmergencyPath);

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(txtMain.Text);
            }
        }

        private static string Anti_Overwrite(string EmergencyPath)
        {
            const string extension = ".txt";
            int i = 0;
            string filename = EmergencyPath + @"\Recovered";
            string newFileName = "";

            if (!File.Exists($"{filename}{extension}")) return newFileName = $"{filename}{extension}";

            if (!File.Exists($"{filename} ({i}){extension}")) return newFileName = $"{filename} ({i}){extension}";

            loopWhile:
            while (File.Exists($"{filename} ({i}){extension}"))
            {
                i++;
                newFileName = $"{filename} ({i}){extension}";
            }

            if (File.Exists($"{filename} ({i}){extension}")) goto loopWhile;

            return newFileName;
        }
    }
}