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
    public partial class registerGUI : Form
    {
        public registerGUI()
        {
            InitializeComponent();
        }
        public static int status = 0;
        private void buttonbox_Click(object sender, EventArgs e)
        {
            if (!hidingcheckbox.Checked || logbox.Text.Contains("'") || passbox.Text.Contains("'") || logbox.Text.Contains("=") || passbox.Text.Contains("=") || logbox.Text.Contains("-") || passbox.Text.Contains("-"))
            {
                checkboxinfo.ForeColor = Color.Red;
                return;
            }
            else
            {
                checkboxinfo.ForeColor = Color.Gainsboro;
                SqlClass sql = new SqlClass();
                sql.RegisterCredentials(logbox.Text, passbox.Text);
                bunifuLabel2.Visible = true;
                labelid.Visible = true;
                labelid.Text = SqlClass.kod;
                buttonbox.Enabled = false;
            }
        }

        private void hidingcheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (hidingcheckbox.Checked)
                checkboxinfo.ForeColor = Color.Gainsboro;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            status = 1;
            this.Hide();
            Login login = new Login();
            login.Show();
            

        }
    }

}
