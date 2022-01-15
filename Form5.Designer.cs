
namespace yeterARTIKYETERSON_BU
{
    partial class Form5
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
            this.geributtonform5 = new System.Windows.Forms.Button();
            this.nasiloynanirbutton = new System.Windows.Forms.Button();
            this.müzikbuttonform5 = new System.Windows.Forms.Button();
            this.sesduzeyibutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // geributtonform5
            // 
            this.geributtonform5.BackColor = System.Drawing.Color.Tan;
            this.geributtonform5.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributtonform5.Location = new System.Drawing.Point(70, 611);
            this.geributtonform5.Name = "geributtonform5";
            this.geributtonform5.Size = new System.Drawing.Size(132, 40);
            this.geributtonform5.TabIndex = 1;
            this.geributtonform5.Text = "<--GERİ DÖN";
            this.geributtonform5.UseVisualStyleBackColor = false;
            this.geributtonform5.Click += new System.EventHandler(this.geributtonform5_Click);
            // 
            // nasiloynanirbutton
            // 
            this.nasiloynanirbutton.BackColor = System.Drawing.Color.Tan;
            this.nasiloynanirbutton.Font = new System.Drawing.Font("Poor Richard", 10.8F, System.Drawing.FontStyle.Bold);
            this.nasiloynanirbutton.Location = new System.Drawing.Point(400, 186);
            this.nasiloynanirbutton.Name = "nasiloynanirbutton";
            this.nasiloynanirbutton.Size = new System.Drawing.Size(194, 46);
            this.nasiloynanirbutton.TabIndex = 39;
            this.nasiloynanirbutton.Text = "NASIL OYNANIR?";
            this.nasiloynanirbutton.UseVisualStyleBackColor = false;
            this.nasiloynanirbutton.Click += new System.EventHandler(this.nasiloynanirbutton_Click);
            // 
            // müzikbuttonform5
            // 
            this.müzikbuttonform5.BackColor = System.Drawing.Color.Tan;
            this.müzikbuttonform5.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.müzikbuttonform5.Location = new System.Drawing.Point(400, 273);
            this.müzikbuttonform5.Name = "müzikbuttonform5";
            this.müzikbuttonform5.Size = new System.Drawing.Size(194, 44);
            this.müzikbuttonform5.TabIndex = 40;
            this.müzikbuttonform5.Text = "MÜZİK TINGIRDAT!";
            this.müzikbuttonform5.UseVisualStyleBackColor = false;
            this.müzikbuttonform5.Click += new System.EventHandler(this.müzikbuttonform5_Click);
            // 
            // sesduzeyibutton
            // 
            this.sesduzeyibutton.BackColor = System.Drawing.Color.Tan;
            this.sesduzeyibutton.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesduzeyibutton.Location = new System.Drawing.Point(400, 362);
            this.sesduzeyibutton.Name = "sesduzeyibutton";
            this.sesduzeyibutton.Size = new System.Drawing.Size(197, 44);
            this.sesduzeyibutton.TabIndex = 41;
            this.sesduzeyibutton.Text = "SES AYARLARI";
            this.sesduzeyibutton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::yeterARTIKYETERSON_BU.Properties.Resources.kahverengi1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 718);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 718);
            this.Controls.Add(this.sesduzeyibutton);
            this.Controls.Add(this.müzikbuttonform5);
            this.Controls.Add(this.nasiloynanirbutton);
            this.Controls.Add(this.geributtonform5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button geributtonform5;
        private System.Windows.Forms.Button nasiloynanirbutton;
        private System.Windows.Forms.Button müzikbuttonform5;
        private System.Windows.Forms.Button sesduzeyibutton;
    }
}