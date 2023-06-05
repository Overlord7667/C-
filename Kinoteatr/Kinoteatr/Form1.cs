using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoteatrDBDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.kinoteatrDBDataSet.Films);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoteatrDBDataSet.KinoteatrFilms". При необходимости она может быть перемещена или удалена.
            this.kinoteatrFilmsTableAdapter.Fill(this.kinoteatrDBDataSet.KinoteatrFilms);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
