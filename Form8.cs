using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace yeterARTIKYETERSON_BU
{
    public partial class Form8 : Form
    {
        SoundPlayer player3 = new SoundPlayer();
        public Form8()
        {
            InitializeComponent();
        }
        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           // axWindowsMediaPlayer1.URL= "C:\\Users\fyama\\OneDrive - Amasya Üniversitesi\\Masaüstü";
        }

        private void videobutton_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
            player3.SoundLocation = @"C:\Users\fyama\source\repos\yeterARTIKYETERSON BU\Resources\Ottoman Theme - Atomic (Civilization 6 OST) _ Yelkenler Biçilecek; Ey büt-i nev edâ olmuşum müptelâ.wav";
            player3.Play();
            // axWindowsMediaPlayer1.URL = "C:\\Users\fyama\\OneDrive - Amasya Üniversitesi\\Masaüstü";
        }
    }
}
