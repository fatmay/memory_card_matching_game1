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
    public partial class Form7 : Form
    {
        SoundPlayer player2 = new SoundPlayer();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void musicbutton_Click(object sender, EventArgs e)
        {
          
                player2.SoundLocation = @"C:\Users\fyama\source\repos\eslestirme_kendim_son\Resources\Kürdilihicazkar Longa.wav";
                player2.Play();
            
        }

        private void zahitbizibutton_Click(object sender, EventArgs e)
        {
            player2.SoundLocation = @"C:\Users\fyama\source\repos\yeterARTIKYETERSON BU\Resources\Zahid Bizi Ta'n Eyleme (Zahid Don't Decry Us).wav";
            player2.Play();
        }

        private void mehterbutton_Click(object sender, EventArgs e)
        {
            player2.SoundLocation = @"C:\Users\fyama\source\repos\yeterARTIKYETERSON BU\Resources\Yelkenler Biçilecek.wav";
            player2.Play();
        }

        private void yavuzbutton_Click(object sender, EventArgs e)
        {
            player2.SoundLocation = @"C:\Users\fyama\source\repos\yeterARTIKYETERSON BU\Resources\YAŞASIN IRKIMIZ    DANS EDEN KURT.wav";
            player2.Play();
        }

        private void geributtonform7_Click(object sender, EventArgs e)
        {

            Form5 fr = new Form5();//form 5 e yönlendir
            fr.Show();
            this.Hide();
        }

        private void muzikdurdurbutton_Click(object sender, EventArgs e)
        {
            player2.Stop();
        }
    }
}
