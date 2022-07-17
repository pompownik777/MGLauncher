using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = DiscordRPC.Button;

namespace MGLauncher
{
    public partial class mainGUI : Form
    {
        public mainGUI()
        {
            InitializeComponent();

        }

        ////////Discord////////Discord////////Discord////////Discord////
        DiscordRpcClient client;
        public void Initialize()
        {

        }

        ////////Discord////////Discord////////Discord////////Discord////////Discord////////Discord////////Discord
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);


        private async void launchButton_Click(object sender, EventArgs e)
        {
            SqlClass sql = new SqlClass();

            if (!bunifuCheckBox1.Checked)
            {
                checkboxinfo.ForeColor = Color.Red;

            }
            else
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.MGPack";
                string zipPath = @"c:\mgZIPPED.zip";
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.MGPack\installed"))
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFile("https://mateuszpack.ga/mateuszpack.zip", zipPath);
                    Directory.CreateDirectory(path);
                    ZipFile.ExtractToDirectory(zipPath, path);


                    SoundPlayer snd = new SoundPlayer(Properties.Resources.loginsound);
                    snd.Play();
                    DialogResult dialogResult = MessageBox.Show("Pobieranie zakończone, włącz launcher ponownie.", "Uwaga!", MessageBoxButtons.OK);

                    if (dialogResult == DialogResult.OK)
                    {
                        File.Delete(@"c:\mgZIPPED.zip");
                        Application.Exit();
                    }

                }


                else
                {
                    string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mg.txt";
                    StreamWriter sw;
                    string text = File.ReadAllText(path2);
                    if (text == "true")
                    {
                        Sprawdz();
                    }
                    //mc//
                 

                    DialogResult dialogResult = MessageBox.Show("Czy posiadasz konto minecraft premium?", "Wybór konta online/offline", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Hide();
                        microsoftLoginGUI mgui = new microsoftLoginGUI();
                        mgui.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Hide();
                        offlineLoginGUI ofl = new offlineLoginGUI();
                        ofl.Show();
                    }

                }
            }


        }

        private void closepic_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("javaw").Length > 0)
            {
                Process[] workers = Process.GetProcessesByName("javaw");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }
            }
            System.Environment.Exit(0);


        }

        private void minpic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //discord
        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {
            infoform info = new infoform();
            info.Show();
        }
        //discord
        private void mainGUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Opacity = .70;
                this.Cursor = System.Windows.Forms.Cursors.SizeAll;
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void mainGUI_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
            this.Opacity = 100;
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void mainGUI_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked)
            {
                string path = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mgeula.txt");

                checkboxinfo.ForeColor = Color.Gainsboro;
                bunifuCheckBox1.Enabled = false;
                checkboxinfo.ForeColor = Color.Green;
                if (File.Exists(path)) ;
                {
                    StreamWriter sw;
                    sw = new StreamWriter(path);
                    sw.Write("true");
                    sw.Close();
                }


            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            settingsGUI sgui = new settingsGUI();
            sgui.Show();

        }

        private void mainGUI_Shown(object sender, EventArgs e)
        {
            string eula = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mgeula.txt");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mglaunchertemp.txt";

            string przeczytane = File.ReadAllText(eula);
            if (przeczytane == "true")
            {
                bunifuCheckBox1.Checked = true;
                bunifuCheckBox1.Enabled = false;
                checkboxinfo.ForeColor = Color.Green;
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mglaunchertemp.txt"))
            {
                string username = File.ReadAllText(path);
                loggeduser.Text = username;

            }
            SoundPlayer snd = new SoundPlayer(Properties.Resources.loginsound);
            snd.Play();


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mainGUI mgui = new mainGUI();
            mgui.Show();
            notifyIcon1.Visible = false;
        }

        private void mainGUI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mg.txt";
            string eula = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mgeula.txt";
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.MGPack\installed"))
            {
                launchButton.Text = "Pobierz i zagraj!";
                downloadlabel.Visible = true;

            }

            if (!File.Exists(path))
            {
                StreamWriter sw;
                sw = File.CreateText(path);
            }

        }

        public async Task Sprawdz()
        {

            var delayTask = Task.Delay(1000);
            while (true)
            {
                if (Process.GetProcessesByName("javaw").Length > 0)
                {
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i += -1)
                    {
                        if (!object.ReferenceEquals(Application.OpenForms[i], this))
                        {

                            Application.OpenForms[i].Hide();
                        }
                    }


                    this.Hide();
                    notifyIcon1.Visible = true;
                    break;

                }
                Application.DoEvents();
                await delayTask;
            }

        }
    }
}
