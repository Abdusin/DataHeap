using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PisanoTeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void anaMenu1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            anaMenu1.Hide();
            deltaIlerleme1.Hide();
            yardım1.Show();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            anaMenu1.Show();
            deltaIlerleme1.Hide();
            yardım1.Hide();

        }

        private void btnIstatislikler_Click(object sender, EventArgs e)
        {

            anaMenu1.Hide();
            deltaIlerleme1.Show();
            yardım1.Hide();
        }
    }
}
