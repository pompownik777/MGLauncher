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
    public partial class microsoftLoginGUI : Form
    {

        public microsoftLoginGUI()
        {
            InitializeComponent();
        }
        public static int status = 0;
        private void buttonbox_Click(object sender, EventArgs e)
        {
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mglaunchersettings.txt";
            LaunchMinecraft lm = new LaunchMinecraft();
            string mb = File.ReadAllText(path2);
            lm.launchMinecraftMicrosoft(Convert.ToInt32(mb));
            bunifuLabel3.Visible = true;

        }
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            status = 1;
            this.Hide();
            mainGUI mgui = new mainGUI();
            mgui.Show();
            

        }

    }

}
