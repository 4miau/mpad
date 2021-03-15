using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static mpad.Settings;
using static mpad.Keydowns;

namespace mpad
{
    public partial class Fonts : Form
    {
        public Fonts()
        {
            InitializeComponent();
        }

        private void Fonts_Load(object sender, EventArgs e)
        {
            string currentFont = "";

            List<float> fontSizes = new List<float>();

            using (StreamReader sr = new StreamReader(fontSizePath))
            {
                fontSizes = sr.ReadToEnd().Split(',').Select(float.Parse).ToList();
            }

            Invoke((MethodInvoker) (() =>
            {
                foreach (FontFamily font in FontFamily.Families)
                {
                    cbxFont.Items.Add(font.Name);
                    if (impConfig.font == font.Name) currentFont = font.Name;
                }

                cbxFont.SelectedItem = currentFont;

                if (fontSizes.Contains(impConfig.fontSize) == false)
                {
                    fontSizes.Add(impConfig.fontSize);
                    fontSizes = fontSizes.OrderBy(i => i).ToList();
                }

                foreach (float i in fontSizes) cbxSize.Items.Add(i);

                cbxSize.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbxSize.SelectedItem = impConfig.fontSize;
            }));

            fontSizes.Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (float.IsNaN(float.Parse(cbxSize.Text)))
                MessageBox.Show("Please input a valid value for Font Size (can be a float).");
            else
            {
                impConfig.font = cbxFont.SelectedItem.ToString();
                impConfig.fontSize = (float) Math.Round(float.Parse(cbxSize.Text), 2);
                Close();
            }
        }
    }
}