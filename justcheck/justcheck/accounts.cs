﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace justcheck
{
    public partial class accounts : Form
    {
        public accounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daily_record obj = new daily_record();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TOTAL obj = new TOTAL();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            final_record obj = new final_record();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accountSalery obj = new accountSalery();
            obj.Show();
        }

        private void accounts_Load(object sender, EventArgs e)
        {

        }

       
    }
}
