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
    public partial class AddProducts : Form
    {
        MagazinDB context;
        List<MagazinModel> magazinModelsName;
        public AddProducts()
        {
            InitializeComponent();
            context = new MagazinDB();
            magazinModelsName = context.MagazinModels.ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MagazinModel magazinModel = new MagazinModel();
            magazinModel.Name = textBox1.Text;
            magazinModel.Price = textBox2.Text;
            magazinModel.Description = textBox3.Text;
            context.MagazinModels.Add(magazinModel);
            context.SaveChanges();
            Close();
        }
    }
}
