using System;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("我真的好可愛~");
            Form btn = new Form_button();
            btn.Show();
        }

        private void btn_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("單身狗♥");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
