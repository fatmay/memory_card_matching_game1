﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void geributtonform3_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();//form 3e yönlendir
            fr.Show();
            this.Hide();
        }
    }
}
