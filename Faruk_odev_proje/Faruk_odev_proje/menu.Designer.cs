namespace Faruk_odev_proje
{
    partial class menu
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
            this.kullanıcı = new System.Windows.Forms.Button();
            this.yonetici = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanıcı
            // 
            this.kullanıcı.Location = new System.Drawing.Point(92, 12);
            this.kullanıcı.Name = "kullanıcı";
            this.kullanıcı.Size = new System.Drawing.Size(75, 23);
            this.kullanıcı.TabIndex = 9;
            this.kullanıcı.Text = "kullanıcı";
            this.kullanıcı.UseVisualStyleBackColor = true;
            this.kullanıcı.Click += new System.EventHandler(this.kullanıcı_Click);
            // 
            // yonetici
            // 
            this.yonetici.Location = new System.Drawing.Point(11, 12);
            this.yonetici.Name = "yonetici";
            this.yonetici.Size = new System.Drawing.Size(75, 23);
            this.yonetici.TabIndex = 8;
            this.yonetici.Text = "yonetici";
            this.yonetici.UseVisualStyleBackColor = true;
            this.yonetici.Click += new System.EventHandler(this.yonetici_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "cık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Faruk_odev_proje.Properties.Resources.makyajli_2021_bmw_m5_competition_3;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 165);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullanıcı);
            this.Controls.Add(this.yonetici);
            this.Controls.Add(this.pictureBox1);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kullanıcı;
        private System.Windows.Forms.Button yonetici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

