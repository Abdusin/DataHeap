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
    public partial class DeltaIlerleme : UserControl
    {
        public DeltaIlerleme()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedIndex == 2)
            {
                label2.Text = "Takipci Sayısı:";
                lblAboneSayisi.Text = "1500";
                label3.Text = "Toplam Paylaşım Sayısı:";
                lblTVideoSayisi.Text = "103";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "2300";
                lblMemnuniyet.Text = "%68";
                

                lblAboneSayisi2.Text = "350";
                lblTVideoSayisi2.Text = "24";
                lblOYorumSayısı2.Text = "97";
                lblMemnuniyet2.Text = "%27";


            }
            else if (bunifuDropdown1.selectedIndex == 1)
            {
                label2.Text = "Abone Sayısı:";
                lblAboneSayisi.Text = "12000";
                label3.Text = "Toplam Video Sayısı:";
                lblTVideoSayisi.Text = "103";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "2300";
                lblMemnuniyet.Text = "%73";

                lblAboneSayisi2.Text = "1260";
                lblTVideoSayisi2.Text = "42";
                lblOYorumSayısı2.Text = "389";
                lblMemnuniyet2.Text = "%39";
            }
            else if (bunifuDropdown1.selectedIndex == 0)
            {
                label2.Text = "Hedef Kitle:";
                lblAboneSayisi.Text = "Sosyal Medya Kullanıcıları";
                label3.Text = "Ulaşılan Kitle :";
                lblTVideoSayisi.Text = "20200";
                label4.Text = "Hedeflenen Kitle Sayısı:";
                lblOYorumSayısı.Text = "36000";
                lblMemnuniyet.Text = "%75";

                lblAboneSayisi2.Text = "Bilinmiyor";
                lblTVideoSayisi2.Text = "1260";
                lblOYorumSayısı2.Text = "Yok";
                lblMemnuniyet2.Text = "%32";
            }
            else if (bunifuDropdown1.selectedIndex == 3)
            {
                label2.Text = "Takipci Sayısı:";
                lblAboneSayisi.Text = "5500";
                label3.Text = "Toplam Paylaşım Sayısı:";
                lblTVideoSayisi.Text = "121";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "2300";
                lblMemnuniyet.Text = "%81";

                lblAboneSayisi2.Text = "560";
                lblTVideoSayisi2.Text = "19";
                lblOYorumSayısı2.Text = "267";
                lblMemnuniyet2.Text = "%31";
            }
            else if (bunifuDropdown1.selectedIndex == 4)
            {
                label2.Text = "Takipci Sayısı:";
                lblAboneSayisi.Text = "360";
                label3.Text = "Toplam Paylaşım Sayısı:";
                lblTVideoSayisi.Text = "33";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "230";
                lblMemnuniyet.Text = "%79";

                lblAboneSayisi2.Text = "90";
                lblTVideoSayisi2.Text = "9";
                lblOYorumSayısı2.Text = "17";
                lblMemnuniyet2.Text = "%21";
            }
            label6.Text = label2.Text;
            label7.Text = label3.Text;
            label8.Text = label4.Text;
        }

        private void DeltaIlerleme_Load(object sender, EventArgs e)
        {
            label2.Text = "Hedef Kitle:";
            lblAboneSayisi.Text = "Sosyal Medya Kullanıcıları";
            label3.Text = "Ulaşılan Kitle :";
            lblTVideoSayisi.Text = "20200";
            label4.Text = "Hedeflenen Kitle Sayısı:";
            lblOYorumSayısı.Text = "36000";
            lblMemnuniyet.Text = "%75";


            lblAboneSayisi2.Text = "Bilinmiyor";
            lblTVideoSayisi2.Text = "1260";
            lblOYorumSayısı2.Text = "Yok";
            lblMemnuniyet2.Text = "%32";

            label6.Text = label2.Text;
            label7.Text = label3.Text;
            label8.Text = label4.Text;
        }

        private void lblMemnuniyet_Click(object sender, EventArgs e)
        {

        }

        private void lblTVideoSayisi_Click(object sender, EventArgs e)
        {

        }

        private void lblAboneSayisi_Click(object sender, EventArgs e)
        {

        }
    }
}
