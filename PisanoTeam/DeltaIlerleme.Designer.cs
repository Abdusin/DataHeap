namespace PisanoTeam
{
    partial class DeltaIlerleme
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuDropdown1 = new ns1.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAboneSayisi = new System.Windows.Forms.Label();
            this.lblTVideoSayisi = new System.Windows.Forms.Label();
            this.lblOYorumSayısı = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMemnuniyet = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAboneSayisi2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTVideoSayisi2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMemnuniyet2 = new System.Windows.Forms.Label();
            this.lblOYorumSayısı2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "Sosyal Mecra(Genel Tanınmışlık)",
        "Youtube",
        "Facebook",
        "Instagram",
        "Google+"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(267, 17);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(262, 34);
            this.bunifuDropdown1.TabIndex = 3;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblOYorumSayısı2);
            this.panel1.Controls.Add(this.lblAboneSayisi2);
            this.panel1.Controls.Add(this.lblMemnuniyet2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblTVideoSayisi2);
            this.panel1.Location = new System.Drawing.Point(29, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 371);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblOYorumSayısı);
            this.panel2.Controls.Add(this.lblMemnuniyet);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTVideoSayisi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblAboneSayisi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(435, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 371);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "BAŞLANGIÇ";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(572, 61);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(88, 25);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "14.10.18";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "14.10.18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "14.10.18";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "14.10.18";
            // 
            // lblAboneSayisi
            // 
            this.lblAboneSayisi.AutoSize = true;
            this.lblAboneSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboneSayisi.Location = new System.Drawing.Point(182, 47);
            this.lblAboneSayisi.Name = "lblAboneSayisi";
            this.lblAboneSayisi.Size = new System.Drawing.Size(57, 13);
            this.lblAboneSayisi.TabIndex = 5;
            this.lblAboneSayisi.Text = "14.10.18";
            this.lblAboneSayisi.Click += new System.EventHandler(this.lblAboneSayisi_Click);
            // 
            // lblTVideoSayisi
            // 
            this.lblTVideoSayisi.AutoSize = true;
            this.lblTVideoSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTVideoSayisi.Location = new System.Drawing.Point(182, 96);
            this.lblTVideoSayisi.Name = "lblTVideoSayisi";
            this.lblTVideoSayisi.Size = new System.Drawing.Size(57, 13);
            this.lblTVideoSayisi.TabIndex = 5;
            this.lblTVideoSayisi.Text = "14.10.18";
            this.lblTVideoSayisi.Click += new System.EventHandler(this.lblTVideoSayisi_Click);
            // 
            // lblOYorumSayısı
            // 
            this.lblOYorumSayısı.AutoSize = true;
            this.lblOYorumSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOYorumSayısı.Location = new System.Drawing.Point(182, 150);
            this.lblOYorumSayısı.Name = "lblOYorumSayısı";
            this.lblOYorumSayısı.Size = new System.Drawing.Size(57, 13);
            this.lblOYorumSayısı.TabIndex = 5;
            this.lblOYorumSayısı.Text = "14.10.18";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Memnuniyet:";
            // 
            // lblMemnuniyet
            // 
            this.lblMemnuniyet.AutoSize = true;
            this.lblMemnuniyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemnuniyet.Location = new System.Drawing.Point(182, 205);
            this.lblMemnuniyet.Name = "lblMemnuniyet";
            this.lblMemnuniyet.Size = new System.Drawing.Size(78, 13);
            this.lblMemnuniyet.TabIndex = 5;
            this.lblMemnuniyet.Text = "Memnuniyet:";
            this.lblMemnuniyet.Click += new System.EventHandler(this.lblMemnuniyet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "14.10.18";
            // 
            // lblAboneSayisi2
            // 
            this.lblAboneSayisi2.AutoSize = true;
            this.lblAboneSayisi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboneSayisi2.Location = new System.Drawing.Point(194, 50);
            this.lblAboneSayisi2.Name = "lblAboneSayisi2";
            this.lblAboneSayisi2.Size = new System.Drawing.Size(57, 13);
            this.lblAboneSayisi2.TabIndex = 5;
            this.lblAboneSayisi2.Text = "14.10.18";
            this.lblAboneSayisi2.Click += new System.EventHandler(this.lblAboneSayisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "14.10.18";
            // 
            // lblTVideoSayisi2
            // 
            this.lblTVideoSayisi2.AutoSize = true;
            this.lblTVideoSayisi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTVideoSayisi2.Location = new System.Drawing.Point(194, 99);
            this.lblTVideoSayisi2.Name = "lblTVideoSayisi2";
            this.lblTVideoSayisi2.Size = new System.Drawing.Size(57, 13);
            this.lblTVideoSayisi2.TabIndex = 5;
            this.lblTVideoSayisi2.Text = "14.10.18";
            this.lblTVideoSayisi2.Click += new System.EventHandler(this.lblTVideoSayisi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "14.10.18";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Memnuniyet:";
            // 
            // lblMemnuniyet2
            // 
            this.lblMemnuniyet2.AutoSize = true;
            this.lblMemnuniyet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemnuniyet2.Location = new System.Drawing.Point(194, 208);
            this.lblMemnuniyet2.Name = "lblMemnuniyet2";
            this.lblMemnuniyet2.Size = new System.Drawing.Size(78, 13);
            this.lblMemnuniyet2.TabIndex = 5;
            this.lblMemnuniyet2.Text = "Memnuniyet:";
            this.lblMemnuniyet2.Click += new System.EventHandler(this.lblMemnuniyet_Click);
            // 
            // lblOYorumSayısı2
            // 
            this.lblOYorumSayısı2.AutoSize = true;
            this.lblOYorumSayısı2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOYorumSayısı2.Location = new System.Drawing.Point(194, 153);
            this.lblOYorumSayısı2.Name = "lblOYorumSayısı2";
            this.lblOYorumSayısı2.Size = new System.Drawing.Size(57, 13);
            this.lblOYorumSayısı2.TabIndex = 5;
            this.lblOYorumSayısı2.Text = "14.10.18";
            // 
            // DeltaIlerleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuDropdown1);
            this.Name = "DeltaIlerleme";
            this.Size = new System.Drawing.Size(805, 555);
            this.Load += new System.EventHandler(this.DeltaIlerleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAboneSayisi;
        private System.Windows.Forms.Label lblTVideoSayisi;
        private System.Windows.Forms.Label lblOYorumSayısı;
        private System.Windows.Forms.Label lblMemnuniyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOYorumSayısı2;
        private System.Windows.Forms.Label lblAboneSayisi2;
        private System.Windows.Forms.Label lblMemnuniyet2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTVideoSayisi2;
    }
}
