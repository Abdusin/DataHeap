using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PisanoTeam
{
    public partial class Yardım : UserControl
    {
        public int deger= 0;

        public Yardım()
        {
            InitializeComponent();
        }

        private void Yardım_Load(object sender, EventArgs e)
        {

        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            if(deger ==0)
            {
                label1.Text = "Tercihlerinz Arasında olan sosyal medyayı seçin";
                deger = 1;
            }else if (deger == 1)
            {
                label1.Text = "Tercihler Arasından olan bir Sürece Tıklayarak İlerleminize Bakın";
                deger = 1;
            }
            pictureBox1.Hide();
            pcHelp2.Show();
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            if (deger == 0)
            {
                label1.Text = "Tercihlerinz Arasında olan sosyal medyayı seçin";
                deger = 1;
            }
            else if (deger == 1)
            {
                label1.Text = "Tercihler Arasından olan bir Sürece Tıklayarak İlerleminize Bakın";
                deger = 1;
            }
            pictureBox1.Show();
            pcHelp2.Hide();
        }
    }
}
