namespace PisanoTeam
{
    partial class Yardım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yardım));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSag = new ns1.BunifuImageButton();
            this.btnSol = new ns1.BunifuImageButton();
            this.pcHelp2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tercihlerinz Arasında olan sosyal medyayı seçin";
            // 
            // btnSag
            // 
            this.btnSag.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSag.Image = ((System.Drawing.Image)(resources.GetObject("btnSag.Image")));
            this.btnSag.ImageActive = null;
            this.btnSag.Location = new System.Drawing.Point(406, 356);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(71, 71);
            this.btnSag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSag.TabIndex = 2;
            this.btnSag.TabStop = false;
            this.btnSag.Zoom = 10;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSol.Image = ((System.Drawing.Image)(resources.GetObject("btnSol.Image")));
            this.btnSol.ImageActive = null;
            this.btnSol.Location = new System.Drawing.Point(297, 356);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(71, 71);
            this.btnSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSol.TabIndex = 2;
            this.btnSol.TabStop = false;
            this.btnSol.Zoom = 10;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // pcHelp2
            // 
            this.pcHelp2.Image = ((System.Drawing.Image)(resources.GetObject("pcHelp2.Image")));
            this.pcHelp2.Location = new System.Drawing.Point(171, 0);
            this.pcHelp2.Name = "pcHelp2";
            this.pcHelp2.Size = new System.Drawing.Size(437, 307);
            this.pcHelp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHelp2.TabIndex = 0;
            this.pcHelp2.TabStop = false;
            // 
            // Yardım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcHelp2);
            this.Name = "Yardım";
            this.Size = new System.Drawing.Size(803, 553);
            this.Load += new System.EventHandler(this.Yardım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuImageButton btnSag;
        private ns1.BunifuImageButton btnSol;
        private System.Windows.Forms.PictureBox pcHelp2;
    }
}
