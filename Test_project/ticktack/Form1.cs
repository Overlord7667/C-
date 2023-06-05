using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticktack
{
    public partial class Form1 : Form
    {
        bool isCross = true;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void NewGame()
        {
            isCross = true;
            count = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        bool isWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
                return true;
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                return true;
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
                return true;
            
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                return true;
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                return true;
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                return true;
            
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
                return true;
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                return true;

            return false;
        }
        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "" && !isWinner())
            { 
                if (isCross == true)
                {
                    button.ForeColor = Color.Red;
                    button.Text = "X";
                }
                else
                {
                    button.ForeColor = Color.Blue;
                    button.Text = "O";
                }
                count++;
                if (isWinner())
                {
                    if (isCross)
                        MessageBox.Show("Победили крестики");
                    else
                        MessageBox.Show("Победили нолики");
                }
                else if (count>=9)
                {
                    MessageBox.Show("НИЧЬЯ!!!");
                }
                isCross = !isCross;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void оСоздателеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void донатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
