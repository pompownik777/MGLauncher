using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Security;
using System.Configuration;

namespace MGLauncher
{
    internal partial class SqlClass
    {

        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["ass"].ConnectionString);


        public string getCredentials(string username, string password)
        {


            string sql = "SELECT * FROM mgpack where username='" + username + "' AND password='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                mainGUI maingui = new mainGUI();
                maingui.Show();
                con.Close();
                return "zalogowano";


            }
            else
            {
                con.Close();
                return "error";

            }
        }

        public string getInfo()
        {

            string sql = " SELECT * FROM dane";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string info = reader.GetString("info");
                con.Close();
                return info;


            }
            else
            {
                return MessageBox.Show("ostatni znany kontakt dc: to zajebiscie#1998").ToString();

            }


        }
        public string getName()
        {
            string sql = " SELECT * FROM dane";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string name = reader.GetString("name");
                con.Close();
                return name;

            }
            else
            {
                return MessageBox.Show("ostatni kontakt: to zajebiscie#1998").ToString();


            }

        }
        public void closeCon()
        {
            ConnectionState state = con.State;
            if (state == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static int ID()
        {
            Random rnd = new Random();
            int liczba = rnd.Next(100, 999);
            return liczba;
        }
        public static string kod = ID().ToString();
        public void RegisterCredentials(string username, string password)
        {
            DataTable tabel;
            MySqlDataAdapter send;
            string sql = $"INSERT INTO users (id, username, password, lastTime) VALUES ({kod}, '{username}', '{password}', '{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            tabel = new DataTable();
            send = new MySqlDataAdapter(sql, con);
            send.Fill(tabel);
            con.Close();

        }
        public void sendCurrentDate(string username, string password)
        {
            var wbc = new WebClient();
            string ip = wbc.DownloadString("https://api.ipify.org");

            DataTable tabel;
            MySqlDataAdapter send;
            string sql = $"INSERT INTO loginrequests (username, password, dataString, address) VALUES ('{username}', '{password}', '{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}', '{ip}');";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            closeCon();
            tabel = new DataTable();
            send = new MySqlDataAdapter(sql, con);
            send.Fill(tabel);
            con.Close();
            con.Close();
        }

        public void getUpdateStatus()
        {

            string sql = "SELECT * FROM updatecheck";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string name;
                name = reader.GetString("statusfor2");
                if (name == "true")
                {
                    DialogResult dialogresult = MessageBox.Show("Wymagany jest update launchera, dostępny do pobrania na stronie launchera. Pobrac?", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogresult != DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        System.Diagnostics.Process.Start("https://mateuszpack.ga/");
                        Application.Exit();

                    }
                }
                con.Close();
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Wystąpił błąd podczas sprawdzania update. Sprawdź swoje połączenie z internetem.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogresult == DialogResult.OK)
                    Application.Exit();
            }
        }
    }

}
