﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("單身狗♥");
            Form btn = new Form_button();
            btn.Show();
        }

        private void button_texBox_Click(object sender, EventArgs e)
        {
            Form form_TextBox = new TextBox();
            form_TextBox.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
