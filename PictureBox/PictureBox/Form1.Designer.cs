namespace PictureBox
{
    partial class Form1
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
            this.Prikazi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sakri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prikazi
            // 
            this.Prikazi.Location = new System.Drawing.Point(176, 415);
            this.Prikazi.Name = "Prikazi";
            this.Prikazi.Size = new System.Drawing.Size(75, 23);
            this.Prikazi.TabIndex = 0;
            this.Prikazi.Text = "Prikaži Sliku";
            this.Prikazi.UseVisualStyleBackColor = true;
            this.Prikazi.Click += new System.EventHandler(this.Prikazi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureBox.Properties.Resources.vrsr;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // sakri
            // 
            this.sakri.Location = new System.Drawing.Point(494, 415);
            this.sakri.Name = "sakri";
            this.sakri.Size = new System.Drawing.Size(75, 23);
            this.sakri.TabIndex = 2;
            this.sakri.Text = "Sakrij Sliku";
            this.sakri.UseVisualStyleBackColor = true;
            this.sakri.Click += new System.EventHandler(this.sakri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sakri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Prikazi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Prikazi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sakri;
    }
}

