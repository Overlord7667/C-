using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
    public partial class Form1 : Form
    {
        Size size;
        int N = 5;
        public Form1()
        {
            InitializeComponent();
            CreateGrid(N);
        }


        //void RefreshGrid()
        //{
        //    dataGridView1.ColumnCount = Size.N;
        //    dataGridView1.RowCount = Size.N;
        //    for (int i = 0; i < Size.N; i++)
        //    {
        //        dataGridView1.Rows[i].Height = 40;
        //        dataGridView1.Columns[i].Width = 40;
        //    }
        //    Height = 50 * Size.N + 40;
        //    Width = 50 * Size.N + 40;
        //}
        void CreateGrid(int n)
        {
           dataGridView1.ColumnCount = n;
           dataGridView1.RowCount = n;
           int w = dataGridView1.Width > dataGridView1.Height ? dataGridView1.Height : dataGridView1.Width;
           for (int i = 0; i < n; i++)
           {
               dataGridView1.Rows[i].Height = w / n;
               dataGridView1.Columns[i].Width = w / n;
           }
        }
        //void ShowData()
        //{
        //    for (int col = 0; col < Size.N; col++)
        //        for (int row = 0; row < Size.N; row++)
        //            dataGridView1[col, row].Value = Size.Area[row, col].ToString();

        //}

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if (dataGridView1[col, row].Style.BackColor == Color.Black)
                dataGridView1[col, row].Style.BackColor = Color.Red;

            else if(dataGridView1[col, row].Style.BackColor == Color.Red)
                  dataGridView1[col, row].Style.BackColor = Color.Green;

            else if(dataGridView1[col, row].Style.BackColor == Color.Green)
                  dataGridView1[col, row].Style.BackColor = Color.Blue;
            
            else if(dataGridView1[col, row].Style.BackColor == Color.Blue)
                  dataGridView1[col, row].Style.BackColor = Color.White;

            else 
                dataGridView1[col, row].Style.BackColor = Color.Black;
            dataGridView1.ClearSelection();

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            N = trackBar1.Value;
            CreateGrid(N);

        }

        private void dataGridView1_Resize_1(object sender, EventArgs e)
        {
            CreateGrid(N);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
