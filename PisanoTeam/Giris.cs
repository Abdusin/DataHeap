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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void txtbtnSifre_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtbxKullanıcı_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(txtbxKullanıcı.text=="admin"&& txtbtnSifre.text == "admin")
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
