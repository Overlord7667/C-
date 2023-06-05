using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double h, w, imt;

        private void button1_Click_1(object sender, EventArgs e)
        {
            string result;
            try 
            { 
            h = Convert.ToDouble(textBox1.Text);
            w = Convert.ToDouble(textBox2.Text);
            h = Math.Abs(h);
            w = Math.Abs(w);
            h /= 100;
            imt = w / (h * h);
            if (imt <= 16)
                result = "Выраженый дефицит массы тела.";
            else if (imt > 16 && imt <= 18.5)
                result = "Недостаточная масса тела.";
            else if (imt > 18.5 && imt <= 25)
                result = "Норма.";
            else if (imt > 25 && imt <= 30)
                result = "Избыточная масса тела(состояние, предшествущее ожирению).";
            else if (imt > 30 && imt <= 35)
                result = "Ожирение 1-й степени.";
            else if (imt > 35 && imt <= 40)
                result = "Ожирение 2-й степени.";
            else
                result = "Ожирение 3-й степени.";
            } catch
            {
                result = "Введены не верные данные!";
            }
            MessageBox.Show(result);
        }
    }
}
