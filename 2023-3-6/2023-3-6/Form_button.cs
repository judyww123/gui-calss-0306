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

    }
}
