namespace OgrenciBilgiSistemi
{
    partial class frmOgretmenGiris
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
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.textBoxOgretmenSifre = new System.Windows.Forms.TextBox();
            this.labelOgrenciNo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGirisYap.Location = new System.Drawing.Point(126, 156);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(183, 52);
            this.buttonGirisYap.TabIndex = 7;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // textBoxOgretmenSifre
            // 
            this.textBoxOgretmenSifre.Location = new System.Drawing.Point(146, 88);
            this.textBoxOgretmenSifre.Name = "textBoxOgretmenSifre";
            this.textBoxOgretmenSifre.Size = new System.Drawing.Size(163, 49);
            this.textBoxOgretmenSifre.TabIndex = 6;
            // 
            // labelOgrenciNo
            // 
            this.labelOgrenciNo.AutoSize = true;
            this.labelOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciNo.Location = new System.Drawing.Point(15, 103);
            this.labelOgrenciNo.Name = "labelOgrenciNo";
            this.labelOgrenciNo.Size = new System.Drawing.Size(109, 29);
            this.labelOgrenciNo.TabIndex = 5;
            this.labelOgrenciNo.Text = "ŞİFRE : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OgrenciBilgiSistemi.Properties.Resources.R;
            this.pictureBox3.Location = new System.Drawing.Point(286, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OgrenciBilgiSistemi.Properties.Resources.R__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmOgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(335, 225);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.textBoxOgretmenSifre);
            this.Controls.Add(this.labelOgrenciNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmOgretmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgretmenGiris";
            this.Load += new System.EventHandler(this.frmOgretmenGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.TextBox textBoxOgretmenSifre;
        private System.Windows.Forms.Label labelOgrenciNo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}