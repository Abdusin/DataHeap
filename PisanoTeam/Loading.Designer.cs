namespace PisanoTeam
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tick1 = new System.Windows.Forms.PictureBox();
            this.Tick2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.lblVerilerniz = new System.Windows.Forms.Label();
            this.lblIstatikler = new System.Windows.Forms.Label();
            this.lblHesaba = new System.Windows.Forms.Label();
            this.pnlAna = new System.Windows.Forms.Panel();
            this.pnlHosgelsiniz = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(130, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tick1
            // 
            this.Tick1.Image = ((System.Drawing.Image)(resources.GetObject("Tick1.Image")));
            this.Tick1.Location = new System.Drawing.Point(213, 148);
            this.Tick1.Name = "Tick1";
            this.Tick1.Size = new System.Drawing.Size(22, 19);
            this.Tick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tick1.TabIndex = 2;
            this.Tick1.TabStop = false;
            // 
            // Tick2
            // 
            this.Tick2.Image = ((System.Drawing.Image)(resources.GetObject("Tick2.Image")));
            this.Tick2.Location = new System.Drawing.Point(213, 167);
            this.Tick2.Name = "Tick2";
            this.Tick2.Size = new System.Drawing.Size(22, 19);
            this.Tick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tick2.TabIndex = 2;
            this.Tick2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHosgeldiniz.Location = new System.Drawing.Point(262, 108);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(224, 29);
            this.lblHosgeldiniz.TabIndex = 3;
            this.lblHosgeldiniz.Text = "Hoş Geldiniz Admin";
            // 
            // lblVerilerniz
            // 
            this.lblVerilerniz.AutoSize = true;
            this.lblVerilerniz.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.lblVerilerniz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVerilerniz.Location = new System.Drawing.Point(257, 148);
            this.lblVerilerniz.Name = "lblVerilerniz";
            this.lblVerilerniz.Size = new System.Drawing.Size(229, 20);
            this.lblVerilerniz.TabIndex = 4;
            this.lblVerilerniz.Text = "Verileriniz toplanıyor";
            // 
            // lblIstatikler
            // 
            this.lblIstatikler.AutoSize = true;
            this.lblIstatikler.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.lblIstatikler.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIstatikler.Location = new System.Drawing.Point(241, 167);
            this.lblIstatikler.Name = "lblIstatikler";
            this.lblIstatikler.Size = new System.Drawing.Size(269, 20);
            this.lblIstatikler.TabIndex = 5;
            this.lblIstatikler.Text = "İstatislikler Hesaplanıyor";
            // 
            // lblHesaba
            // 
            this.lblHesaba.AutoSize = true;
            this.lblHesaba.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.lblHesaba.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHesaba.Location = new System.Drawing.Point(209, 194);
            this.lblHesaba.Name = "lblHesaba";
            this.lblHesaba.Size = new System.Drawing.Size(319, 20);
            this.lblHesaba.TabIndex = 5;
            this.lblHesaba.Text = "Hesabınıza Yönlendiriliyorsunuz";
            // 
            // pnlAna
            // 
            this.pnlAna.Location = new System.Drawing.Point(203, 99);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(350, 122);
            this.pnlAna.TabIndex = 6;
            // 
            // pnlHosgelsiniz
            // 
            this.pnlHosgelsiniz.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHosgelsiniz.Location = new System.Drawing.Point(203, 99);
            this.pnlHosgelsiniz.Name = "pnlHosgelsiniz";
            this.pnlHosgelsiniz.Size = new System.Drawing.Size(350, 46);
            this.pnlHosgelsiniz.TabIndex = 7;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 233);
            this.Controls.Add(this.pnlHosgelsiniz);
            this.Controls.Add(this.lblHesaba);
            this.Controls.Add(this.lblIstatikler);
            this.Controls.Add(this.lblVerilerniz);
            this.Controls.Add(this.Tick2);
            this.Controls.Add(this.Tick1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.pnlAna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Tick1;
        private System.Windows.Forms.PictureBox Tick2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.Label lblVerilerniz;
        private System.Windows.Forms.Label lblIstatikler;
        private System.Windows.Forms.Label lblHesaba;
        private System.Windows.Forms.Panel pnlHosgelsiniz;
        private System.Windows.Forms.Panel pnlAna;
    }
}