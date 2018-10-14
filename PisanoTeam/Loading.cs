using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PisanoTeam
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();

            int deger = 0;
            Thread.Sleep(1000);
            pnlHosgelsiniz.Visible = false;
            deger++;
            Thread.Sleep(2000);
            lblVerilerniz.Visible = true;
            deger++;
            Thread.Sleep(2000);
            Tick1.Visible = true;
            deger++;
            Thread.Sleep(2000);
            lblIstatikler.Visible = true;
            deger++;
            Thread.Sleep(1000);
            Tick2.Visible = true;
            deger++;
            Thread.Sleep(1000);
            lblHesaba.Visible = true;
            deger++;
            Thread.Sleep(2000);
            if (deger == 6)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
