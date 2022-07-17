using DiscordRPC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Button = DiscordRPC.Button;

namespace MGLauncher
{
    public partial class Login : Form
    {

        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mglaunchertemp.txt";

        StreamWriter sw;

        public Login()
        {
            InitializeComponent();

        }
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        SqlClass sql = new SqlClass();

        private void closebox_Click(object sender, EventArgs e)
        {

            System.Environment.Exit(0);


        }




        private void minbox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Logowanie_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Opacity = .70;
                this.Cursor = System.Windows.Forms.Cursors.SizeAll;
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Logowanie_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _dragging = false;
            this.Opacity = 100;
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void Logowanie_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            infoform info = new infoform();
            info.Show();
        }

        private void buttonbox_Click(object sender, EventArgs e)
        {


            if (logbox.Text.Contains("'") || passbox.Text.Contains("'") || logbox.Text.Contains("=") || passbox.Text.Contains("=") || logbox.Text.Contains("-") || passbox.Text.Contains("-"))
            {
                wronglabel.Visible = true;
                return;
            }
            sql.sendCurrentDate(logbox.Text, passbox.Text);
            if (sql.getCredentials(logbox.Text, passbox.Text).ToString() == "zalogowano")
            {
                Hide();
                sw = new StreamWriter(path);
                sw.Write(logbox.Text);
                sw.Close();

            }
            else
            {
                wronglabel.Visible = true;
            }


        }

        private void slider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (slider.Value >= 30)
            {
                img1.ImageLocation = "https://i.imgur.com/9t3pOKA.png";
            }
            if (slider.Value >= 70)
            {
                img1.ImageLocation = "https://i.imgur.com/Ggo0G1f.jpeg";
            }
            else if (slider.Value < 30)
            {
                img1.ImageLocation = "https://i.imgur.com/g883Q1l.png";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            sql.getUpdateStatus();
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }
            mainGUI mgui = new mainGUI();

            if (registerGUI.status == 0)
            {
                DiscordRpcClient client;

                client = new DiscordRpcClient("971409381809848341");


                client.Initialize();
                SqlClass sql = new SqlClass();

                client.SetPresence(new RichPresence()
                {

                    Buttons = new Button[]
                    {
                    new Button() { Label = "Pobierz", Url = "https://mateuszpack.ga" }
                    },
                    Details = "W Launcherze.",
                    State = "Paczka modów i launcher autorstwa: " + sql.getName(),
                    Timestamps = Timestamps.Now,


                    Assets = new Assets()
                    {

                        LargeImageKey = "zdjecie",
                        LargeImageText = "MGLauncher - Launcher modów do minecrafta.",
                        SmallImageKey = "580b57fcd9996e24bc43c2f1"


                    }



                });


                async Task Sprawdz()
                {

                    var delayTask = Task.Delay(1000);
                    while (true)
                    {
                        if (Process.GetProcessesByName("javaw").Length > 0)
                        {
                            {
                                client.Dispose();
                            }

                            break;

                        }
                        Application.DoEvents();
                        await delayTask;
                    }

                }
                Sprawdz();

            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\loginsound.wav")) ;

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://dl.dropboxusercontent.com/s/p0coku65h9gztc2/loginsound.wav?dl=0", (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\loginsound.wav"));
            string eula = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\mgeula.txt");

            if (!File.Exists(eula))
            {
                StreamWriter sw;
                sw = File.CreateText(eula);
            }
        }


        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerGUI rui = new registerGUI();
            rui.Show();
        }

        private void passbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonbox_Click(sender, e);
                SystemSounds.Exclamation.Play();
            }
        }


    }

}