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
    public partial class Form1 : Form
    {

        SoundPlayer player = new SoundPlayer();
       
        Image[] fotograflar =
        {
            
            Properties.Resources.abdulhamid,
            Properties.Resources.murad__2_,
            Properties.Resources.yavuzsultan,
            Properties.Resources.yildirimbeyazid,
            Properties.Resources.tugra2

          };

        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };

        PictureBox ilkkutu;
        int ilkindeks, bulunan, deneme, score = 0;
        public Form1()
        {

            InitializeComponent();
            scorelbl.Text = score.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            resimlerikaristir();
        }
 
        int saniye = 0, dakika = 0, saat = 0, durum = 0;//kronometre label kodu

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 10)
            {
                saniye = 0;
                dakika++;

            }
            if (dakika == 60)
            {
                dakika = 0;
                saniye = 0;
                saat++;
            }
            kronometrelbl.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++;

        }

        private void resetbutton_Click(object sender, EventArgs e)//kronoometre reset butonu kodu
        {

            saat = 0;
            dakika = 0;
            saniye = 0;
            kronometrelbl.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
        }

        private void startandstopbutton_Click_1(object sender, EventArgs e)//start veya stop butonu
        {
            if (durum == 0)
            {
                startandstopbutton.Text = "durdur";
                durum = 1;
                timer1.Start();
            }
            else if (durum == 1)
            {
                startandstopbutton.Text = "baslat";
                durum = 0;
                timer1.Stop();
            }

        }
        private void resimlerikaristir()//esas kart oyunu burada gerçekleşiyor
        {
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                int sayi = rnd.Next(8);//0 DAN 8 e KADAR RASTGELE ELEMAN SECİYO
                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox kutu = (PictureBox)sender;
            int kutuNo = int.Parse(kutu.Name.Substring(10)) - 1;
            int indeksNo = indeksler[kutuNo];
            kutu.Image = fotograflar[indeksNo];
             
            kutu.Refresh();

            if (ilkkutu == null)
            {
                ilkkutu = kutu;

                ilkindeks = indeksNo;
                deneme++;
            }
            else
            {
                System.Threading.Thread.Sleep(600);//o anda çalışan kutuları bekletiyoruz
                ilkkutu.Image = Properties.Resources.tugra2;
                kutu.Image = Properties.Resources.tugra2;
                if (ilkindeks == indeksNo)
                {
                    bulunan++;
                    ilkkutu.Visible = false;//görünürlüğünü false yaptık
                    kutu.Visible = false;
                    score += 100;
                    scorelbl.Text = score.ToString();

                    if (bulunan == 4)
                    {
                        MessageBox.Show("Tüm padişahları"  + deneme + ".denemede bildin! Artık Osmanlı Savaşlarına hazırsın! ");
                        bulunan = 0;
                        deneme = 0;
                        foreach (Control kontrol in Controls)
                        {
                            kontrol.Visible = true;
                        }
                        resimlerikaristir();
                    }
                }
                ilkkutu = null;
            }
        }
    }
}
