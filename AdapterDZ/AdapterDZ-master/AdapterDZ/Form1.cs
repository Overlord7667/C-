using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterDZ
{
    public partial class Form1 : Form
    {
        TextView textView;
        TextGraphics textGraphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void readTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TEXT|*.gm";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                textView = new TextView();
                textGraphics = new TextGraphics(pictureBox1.CreateGraphics(), textView);
                textView.LoadFromFile(openFileDialog.FileName);
            }
        }
    }
}
