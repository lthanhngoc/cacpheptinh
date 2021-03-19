using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cacpheptinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            double kq = a + b;
            txtkq.Text = kq.ToString();
        }
        }
    }
