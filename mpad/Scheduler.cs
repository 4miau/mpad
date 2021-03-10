using System;
using System.IO;
using System.Windows.Forms;

/*
Prop:
0. opened (bool)
1. saved (bool)
2. path (string)
3. content (string)
4. filename (string)
5. textbox (string)
6. text to find
7. found instance?
 */

namespace mpad
{
    class Data
    {
        public static bool opened = false;
        public static bool saved = true;

        public static string path = "";
        public static string content = "";
        public static string filename = "Untitled";
    }

    internal class Scheduler
    {

        internal static void Open()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Open Text File",
                Filter = "Text files|*.txt|All Files (*.)|*.*",
                InitialDirectory = @"C:\"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                Data.path = Path.GetFullPath(ofd.FileName);
                Data.filename = ofd.SafeFileName;

                if (!File.Exists(Data.path)) return;
                using (StreamReader sr = new StreamReader(Data.path))
                {
                    var content = sr.ReadToEnd();
                    Data.content = content;
                }

                Data.saved = true;
                Data.opened = true;
            }
            catch (Exception)
            {
                Data.opened = false;
            }
        }

        internal static void Save(string text)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = "Untitled.txt",
                Filter = "Text File (*.txt)|*.txt|All Files (*.)|*.*",
                DefaultExt = ".txt",
                Title = "Save Text File",
                InitialDirectory = @"C:\"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;
            {
                try
                {
                    Data.path = Path.GetFullPath(sfd.FileName);
                    Data.filename = sfd.FileName.Substring(sfd.FileName.LastIndexOf('\\') + 1);

                    using (StreamWriter sw = new StreamWriter(Data.path))
                    {
                        sw.Write(text);
                        Data.saved = true;
                        Data.opened = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("File could not be saved, error has been generated.", "This is a caption.", MessageBoxButtons.OK);
                    Data.saved = false;
                }
            }

        }

        internal static void Update(string Text)
        {
            Data.content = Text;
        }
    }
}