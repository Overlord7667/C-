using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class UpdateT : Form
    {
        UniversityEntities context;
        List<Cathedras> cathedrasName;
        public UpdateT()
        {
            InitializeComponent();
            context = new UniversityEntities();
            cathedrasName = context.Cathedras.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Name = textBox6.Text;
            context.SaveChanges();
            textBox6.Refresh();
            Close();
        }
    }
}
