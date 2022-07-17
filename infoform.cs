using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGLauncher
{
    public partial class infoform : Form
    {
        public infoform()
        {
            InitializeComponent();
        }

        private void infoform_Load(object sender, EventArgs e)
        {
            SqlClass sql = new SqlClass();
            sql.closeCon();
            infotext.Text = sql.getInfo();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
