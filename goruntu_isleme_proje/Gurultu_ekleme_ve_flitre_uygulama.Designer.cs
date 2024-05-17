
namespace goruntu_isleme_proje
{
    partial class Gurultu_ekleme_ve_flitre_uygulama
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnResimAl = new System.Windows.Forms.Button();
            this.btnGurultuEkle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMeanFiltre = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMedian = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(294, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 210);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnResimAl
            // 
            this.btnResimAl.Location = new System.Drawing.Point(12, 238);
            this.btnResimAl.Name = "btnResimAl";
            this.btnResimAl.Size = new System.Drawing.Size(94, 29);
            this.btnResimAl.TabIndex = 2;
            this.btnResimAl.Text = "Resmi Al";
            this.btnResimAl.UseVisualStyleBackColor = true;
            this.btnResimAl.Click += new System.EventHandler(this.btnResimAl_Click);
            // 
            // btnGurultuEkle
            // 
            this.btnGurultuEkle.Location = new System.Drawing.Point(294, 238);
            this.btnGurultuEkle.Name = "btnGurultuEkle";
            this.btnGurultuEkle.Size = new System.Drawing.Size(145, 29);
            this.btnGurultuEkle.TabIndex = 3;
            this.btnGurultuEkle.Text = "Gürültü Ekle";
            this.btnGurultuEkle.UseVisualStyleBackColor = true;
            this.btnGurultuEkle.Click += new System.EventHandler(this.btnGurultuEkle_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(573, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 210);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnMeanFiltre
            // 
            this.btnMeanFiltre.Location = new System.Drawing.Point(573, 250);
            this.btnMeanFiltre.Name = "btnMeanFiltre";
            this.btnMeanFiltre.Size = new System.Drawing.Size(145, 29);
            this.btnMeanFiltre.TabIndex = 5;
            this.btnMeanFiltre.Text = "Mean Filtre";
            this.btnMeanFiltre.UseVisualStyleBackColor = true;
            this.btnMeanFiltre.Click += new System.EventHandler(this.btnMeanFiltre_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(858, 285);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 9;
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(838, 250);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(145, 29);
            this.btnMedian.TabIndex = 8;
            this.btnMedian.Text = "Median Filtre";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(838, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 210);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Gurultu_ekleme_ve_flitre_uygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMeanFiltre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGurultuEkle);
            this.Controls.Add(this.btnResimAl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Gurultu_ekleme_ve_flitre_uygulama";
            this.Text = "Gurultu_ekleme_ve_flitre_uygulama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnResimAl;
        private System.Windows.Forms.Button btnGurultuEkle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMeanFiltre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}