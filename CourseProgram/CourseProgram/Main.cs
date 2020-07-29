﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProgram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            or.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderLines ol = new OrderLines();
            ol.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Products pr = new Products();
            pr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Plans pl = new Plans();
            pl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Information inf =  new Information();
            inf.Show();
        }
    }
}
