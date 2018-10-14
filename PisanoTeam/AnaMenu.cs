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
    public partial class AnaMenu : UserControl
    {
        public int deger;

        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if(bunifuDropdown1.selectedIndex==2)
            {
                lblLink.Text = "facebook.com/kullaniciadi";
                label2.Text = "Takipci Sayısı:";
                lblAboneSayisi.Text = "1500";
                label3.Text = "Toplam Paylaşım Sayısı:";
                lblTVideoSayisi.Text = "103";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "2300";
                lblMemnuniyet.Text = "%68";

                pcInstagram.Hide();
                pcYoutube.Hide();
                pcWifi.Hide();
                pcGoogle.Hide();
                pcFacebook.Show();
                deger = 2;
            }
            else if (bunifuDropdown1.selectedIndex == 1)
            {
                lblLink.Text = "Youtube.com/kullaniciadi";
                label2.Text = "Abone Sayısı:";
                lblAboneSayisi.Text = "12000";
                label3.Text = "Toplam Video Sayısı:";
                lblTVideoSayisi.Text = "103";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "2300";
                lblMemnuniyet.Text = "%73";

                pcInstagram.Hide();
                pcYoutube.Show();
                pcWifi.Hide();
                pcGoogle.Hide();
                pcFacebook.Hide();
                deger = 1;
            }
            else if (bunifuDropdown1.selectedIndex == 0)
            {
                lblLink.Text = "Admin";
                label2.Text = "Hedef Kitle:";
                lblAboneSayisi.Text = "Sosyal Medya Kullanıcıları";
                label3.Text = "Ulaşılan Kitle :";
                lblTVideoSayisi.Text = "20200";
                label4.Text = "Hedeflenen Kitle Sayısı:";
                lblOYorumSayısı.Text = "36000";
                lblMemnuniyet.Text = "%75";

                pcInstagram.Hide();
                pcYoutube.Hide();
                pcWifi.Show();
                pcGoogle.Hide();
                pcFacebook.Hide();
                deger = 0;
            }
            else if (bunifuDropdown1.selectedIndex == 3)
            {
                lblLink.Text = "Instagram.com/admin";
                label2.Text = "Takipci Sayısı:";
                lblAboneSayisi.Text = "5500";
                label3.Text = "Toplam Paylaşım Sayısı:";
                lblTVideoSayisi.Text = "121";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "2300";
                lblMemnuniyet.Text = "%81";

                pcInstagram.Show();
                pcYoutube.Hide();
                pcWifi.Hide();
                pcGoogle.Hide();
                pcFacebook.Hide();
                deger = 3; 
            }
            else if (bunifuDropdown1.selectedIndex == 4)
            {
                lblLink.Text = "GooglePlus.com/admin";
                label2.Text = "Takipci Sayısı:";
                lblAboneSayisi.Text = "360";
                label3.Text = "Toplam Paylaşım Sayısı:";
                lblTVideoSayisi.Text = "33";
                label4.Text = "Toplam Yorum Sayısı:";
                lblOYorumSayısı.Text = "230";
                lblMemnuniyet.Text = "%79";

                pcInstagram.Hide();
                pcYoutube.Hide();
                pcWifi.Hide();
                pcGoogle.Show();
                pcFacebook.Hide();
                deger = 4;
            }
        }

        
        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            switch (bunifuDropdown2.selectedIndex)
            {
                case 1:
                    pb1.Show();
                    pb2.Show();
                    pb3.Show();

                    lblDeger1.Show();
                    lblDeger2.Show();
                    lblDeger3.Show();

                    lblHedef1.Show();
                    lblHedef2.Show();
                    lblHedef3.Show();

                    pb1.Value = 70;
                    pb2.Value = 46;
                    pb3.Value = 86;

                    lblDeger1.Text = "%" + pb1.Value;
                    lblDeger2.Text = "%" + pb2.Value;
                    lblDeger3.Text = "%" + pb3.Value;

                    lblHedef1.Text = "Günlük Hedef" ;
                    lblHedef2.Text = "Ulaşılan Kitle" ;
                    lblHedef3.Text = "Memnuniyet" ;
                    ; break;

                case 2:
                    pb1.Show();
                    pb2.Show();
                    pb3.Show();

                    lblDeger1.Show();
                    lblDeger2.Show();
                    lblDeger3.Show();

                    lblHedef1.Show();
                    lblHedef2.Show();
                    lblHedef3.Show();

                    pb1.Value = 56;
                    pb2.Value = 32;
                    pb3.Value = 75;

                    lblDeger1.Text = "%" + pb1.Value;
                    lblDeger2.Text = "%" + pb2.Value;
                    lblDeger3.Text = "%" + pb3.Value;

                    lblHedef1.Text = "Haftalık Hedef";
                    lblHedef2.Text = "Ulaşılan Kitle";
                    lblHedef3.Text = "Memnuniyet";
                    ; break;

                case 3:
                    pb1.Show();
                    pb2.Show();
                    pb3.Show();

                    lblDeger1.Show();
                    lblDeger2.Show();
                    lblDeger3.Show();

                    lblHedef1.Show();
                    lblHedef2.Show();
                    lblHedef3.Show();

                    pb1.Value = 42;
                    pb2.Value = 26;
                    pb3.Value = 66;

                    lblDeger1.Text = "%" + pb1.Value;
                    lblDeger2.Text = "%" + pb2.Value;
                    lblDeger3.Text = "%" + pb3.Value;

                    lblHedef1.Text = "Aylık Hedef";
                    lblHedef2.Text = "Ulaşılan Kitle";
                    lblHedef3.Text = "Memnuniyet";
                    ; break;

                case 4:
                    pb1.Show();
                    pb2.Show();
                    pb3.Show();

                    lblDeger1.Show();
                    lblDeger2.Show();
                    lblDeger3.Show();

                    lblHedef1.Show();
                    lblHedef2.Show();
                    lblHedef3.Show();

                    pb1.Value = 21;
                    pb2.Value = 13;
                    pb3.Value = 36;

                    lblDeger1.Text = "%" + pb1.Value;
                    lblDeger2.Text = "%" + pb2.Value;
                    lblDeger3.Text = "%" + pb3.Value;

                    lblHedef1.Text = "Yıllık Hedef";
                    lblHedef2.Text = "Ulaşılan Kitle";
                    lblHedef3.Text = "Memnuniyet";
                    ; break;

                case 0:
                    pb1.Hide();
                    pb2.Show();
                    pb3.Hide();

                    lblDeger1.Hide();
                    lblDeger2.Show();
                    lblDeger3.Hide();

                    lblHedef1.Hide();
                    lblHedef2.Show();
                    lblHedef3.Hide();

                    pb1.Value = 56;
                    pb2.Value = 11;
                    pb3.Value = 75;

                    lblDeger1.Text = "%" + pb1.Value;
                    lblDeger2.Text = "%" + pb2.Value;
                    lblDeger3.Text = "%" + pb3.Value;

                    lblHedef1.Text = "Haftalık Hedef";
                    lblHedef2.Text = "Tüm Süreç";
                    lblHedef3.Text = "Memnuniyet";
                    ; break;

                default:
                    break;
            }
        }
        
    }
}
