
namespace goruntu_isleme_proje
{
	partial class binary_donusum
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.goruntuyuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.binaryDonusumUygulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(382, 301);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goruntuyuAlToolStripMenuItem,
            this.binaryDonusumUygulaToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(237, 52);
			// 
			// goruntuyuAlToolStripMenuItem
			// 
			this.goruntuyuAlToolStripMenuItem.Name = "goruntuyuAlToolStripMenuItem";
			this.goruntuyuAlToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
			this.goruntuyuAlToolStripMenuItem.Text = "Görüntüyü Al";
			this.goruntuyuAlToolStripMenuItem.Click += new System.EventHandler(this.goruntuyuAlToolStripMenuItem_Click);
			// 
			// binaryDonusumUygulaToolStripMenuItem
			// 
			this.binaryDonusumUygulaToolStripMenuItem.Name = "binaryDonusumUygulaToolStripMenuItem";
			this.binaryDonusumUygulaToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
			this.binaryDonusumUygulaToolStripMenuItem.Text = "Binary Dönüşüm Uygula";
			this.binaryDonusumUygulaToolStripMenuItem.Click += new System.EventHandler(this.binaryDonusumUygulaToolStripMenuItem_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.ContextMenuStrip = this.contextMenuStrip1;
			this.pictureBox2.Location = new System.Drawing.Point(388, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(412, 301);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(257, 339);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(125, 27);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(180, 346);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "threshold";
			// 
			// binary_donusum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "binary_donusum";
			this.Text = "binary_donusum";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem goruntuyuAlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem binaryDonusumUygulaToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}