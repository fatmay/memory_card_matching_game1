using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeterARTIKYETERSON_BU
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
      
        private void oyunabaslabutton_Click_1(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void ayarlarbutton_Click_1(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 fr = new Form9();
            fr.Show();
            this.Hide();
        }
    }
}
