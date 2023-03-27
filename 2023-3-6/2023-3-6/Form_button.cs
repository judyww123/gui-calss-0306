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
    public partial class Form_button : Form
    {
        public Form_button()
        {
            InitializeComponent();
        }

        private void Form_button_Load(object sender, EventArgs e)
        {

        }

        private void btn_button1_Click(object sender, EventArgs e)
        {
            if (btn_button1.Text == "請再按一次")
                btn_button1.Text = "你已經按過了";

            else if (btn_button1.Text == "你已經按過了")
                btn_button1.Text = "請再按一次";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "下方按鈕被按過";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = label3.Text;
            int count = 0;
            count = Int32.Parse(temp) + 1;
            label3.Text = "0";
            label3.Text = count + "";
            label3.Text = count.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            short sizeNum = 10;
            button3.Size = new Size(button3.Width + sizeNum, button3.Height + sizeNum);
        }
    }
}
