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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void nasiloynanirbutton_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void müzikbuttonform5_Click(object sender, EventArgs e)
        {

            Form7 fr = new Form7();//form 7 ye yönlendir
            fr.Show();
            this.Hide();
        }

        private void geributtonform5_Click(object sender, EventArgs e)
        {

            Form3 fr = new Form3();//form 7 ye yönlendir
            fr.Show();
            this.Hide();
        }
    }
}
