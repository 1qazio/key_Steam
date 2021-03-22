using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_Steam
{
    public partial class Form1 : Form
    {
        const String Key_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        string generate()
        {
            String result = "";
            for (int i = 1; i <= 5; i++)
                result += Key_chars[rnd.Next(0,Key_chars.Length)];
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for(int i=1; i<= namber.Value;i++)
            textBox1.Text += generate() +"-"+ generate()+ "-" + generate() + "\r\n";

        }
    }
}
