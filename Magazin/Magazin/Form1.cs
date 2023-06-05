using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Form1 : Form
    {
        MagazinModel magazinModel;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDBDataSet.MagazinModels". При необходимости она может быть перемещена или удалена.
            this.magazinModelsTableAdapter.Fill(this.magazinDBDataSet.MagazinModels);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProducts addProduct = new AddProducts();
            addProduct.ShowDialog();
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MagazinDB context = new MagazinDB();
            MagazinModel produkt = context.MagazinModels.Find(magazinModel.Id);
            if(dataGridView1.CurrentCell.ColumnIndex==0)
            produkt.Name = dataGridView1.CurrentCell.Value.ToString();
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            produkt.Price = dataGridView1.CurrentCell.Value.ToString();
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            produkt.Description = dataGridView1.CurrentCell.Value.ToString();
            context.SaveChanges();
            dataGridView1.Refresh();
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MagazinDB context = new MagazinDB();
            string x = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            MagazinModel magazinModel = (from Magazin in context.MagazinModels
                                         where Magazin.Name.Contains(x)
                                         select Magazin).FirstOrDefault();
            context.MagazinModels.Remove(magazinModel);
            context.SaveChanges();
            Application.Restart();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MagazinDB context = new MagazinDB();
            //  if(e.ColumnIndex==0)
            //MessageBox.Show( dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            string x = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                magazinModel = (from Magazin in context.MagazinModels
                               where Magazin.Name.Contains (x)
                               select Magazin).FirstOrDefault();
        }
    }
}
