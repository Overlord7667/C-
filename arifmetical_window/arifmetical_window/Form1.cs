using System;
using System.Windows.Forms;

namespace arifmetical_window
{
    public partial class Form1 : Form
    {
        string s;
        double a;
        double b;
        double c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            a = Convert.ToDouble(s);
            c = a + b;
            textBox3.Text = Convert.ToString(c);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            b = Convert.ToDouble(s);
            c = a + b;
            textBox3.Text = Convert.ToString(c);
        }
    }
}
