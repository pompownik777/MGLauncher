using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGLauncher
{
    public partial class settingsGUI : Form
    {
        public settingsGUI()
        {
            InitializeComponent();
        }
        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mg.txt";
        StreamWriter sw;
        string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mglaunchersettings.txt";

        private void hidingcheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            if (hidingcheckbox.Checked)
            {
                sw = new StreamWriter(path);
                sw.Write("true");
                sw.Close();
            }
            else
            {
                sw = new StreamWriter(path);
                sw.Write("false");
                sw.Close();
            }

            if (rambox.Text.Length <= 3)
            {
                MessageBox.Show("Przydzielony ram musi byc wiekszy niz 999MB!");
            }
            else
            {
                mainGUI maingui = new mainGUI();
                maingui.Show();
                this.Hide();

                sw = new StreamWriter(path2);
                sw.Write(rambox.Text);
                sw.Close();
            }

        }

        private void settingsGUI_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText(path);
            if (text == "true")
            {
                hidingcheckbox.Checked = true;
            }
            else
            {
                hidingcheckbox.Checked = false;
            }

            if (!File.Exists(path2))
            {
                File.CreateText(path2);
            }
            else
            {
                string megabytes = (File.ReadAllText(path2));
                rambox.Text = megabytes.ToString();
            }
        }

    }
}
