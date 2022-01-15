
namespace yeterARTIKYETERSON_BU
{
    partial class Form3
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
            this.ayarlarbutton = new System.Windows.Forms.Button();
            this.oyunabaslabutton = new System.Windows.Forms.Button();
            this.bilgilerbutton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ayarlarbutton
            // 
            this.ayarlarbutton.BackColor = System.Drawing.Color.Tan;
            this.ayarlarbutton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.ayarlarbutton.Location = new System.Drawing.Point(297, 449);
            this.ayarlarbutton.Name = "ayarlarbutton";
            this.ayarlarbutton.Size = new System.Drawing.Size(194, 38);
            this.ayarlarbutton.TabIndex = 39;
            this.ayarlarbutton.Text = "AYARLAR";
            this.ayarlarbutton.UseVisualStyleBackColor = false;
            this.ayarlarbutton.Click += new System.EventHandler(this.ayarlarbutton_Click_1);
            // 
            // oyunabaslabutton
            // 
            this.oyunabaslabutton.BackColor = System.Drawing.Color.Tan;
            this.oyunabaslabutton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.oyunabaslabutton.Location = new System.Drawing.Point(297, 253);
            this.oyunabaslabutton.Name = "oyunabaslabutton";
            this.oyunabaslabutton.Size = new System.Drawing.Size(194, 38);
            this.oyunabaslabutton.TabIndex = 40;
            this.oyunabaslabutton.Text = "OYUNA BAŞLA\r\n";
            this.oyunabaslabutton.UseVisualStyleBackColor = false;
            this.oyunabaslabutton.Click += new System.EventHandler(this.oyunabaslabutton_Click_1);
            // 
            // bilgilerbutton
            // 
            this.bilgilerbutton.BackColor = System.Drawing.Color.Tan;
            this.bilgilerbutton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.bilgilerbutton.Location = new System.Drawing.Point(297, 350);
            this.bilgilerbutton.Name = "bilgilerbutton";
            this.bilgilerbutton.Size = new System.Drawing.Size(194, 38);
            this.bilgilerbutton.TabIndex = 42;
            this.bilgilerbutton.Text = " BİLGİLER";
            this.bilgilerbutton.UseVisualStyleBackColor = false;
            this.bilgilerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Tan;
            this.linkLabel1.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(178, 107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(489, 38);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "OTTOMAN CARDS WAR GAME!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::yeterARTIKYETERSON_BU.Properties.Resources.kahverengi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 747);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 747);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bilgilerbutton);
            this.Controls.Add(this.oyunabaslabutton);
            this.Controls.Add(this.ayarlarbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ayarlarbutton;
        private System.Windows.Forms.Button oyunabaslabutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bilgilerbutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}