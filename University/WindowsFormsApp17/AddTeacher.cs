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
    public partial class AddTeacher : Form
    {
        UniversityEntities context;
        List<Cathedras> cathedrasName;
        public AddTeacher()
        {
            InitializeComponent();
            context = new UniversityEntities();
            cathedrasName = context.Cathedras.ToList();
            foreach (Cathedras cathedras in cathedrasName)
            {
                comboBox1.Items.Add(cathedras.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Name = textBox1.Text;
            teachers.Bday = dateTimePicker1.Value;
            teachers.Cathedras = cathedrasName[comboBox1.SelectedIndex];
            context.Teachers.Add(teachers);
            context.SaveChanges();
            Close();
        }
    }
}
