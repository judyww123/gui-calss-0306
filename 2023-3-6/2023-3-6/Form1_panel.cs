using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2023_3_6
{
    public partial class Form1_panel : Form
    {
        public Form1_panel()
        {
            InitializeComponent();
            File.WriteAllText("Temp.txt", "Hello I'm JUDY\n");
            File.AppendAllText("Temp.txt", "我是第2行\n");
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
