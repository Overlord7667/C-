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
    public partial class AddStudent : Form
    {
        UniversityEntities context;
        List<Teachers>teachersName ;
        List<Cathedras>cathedralsName ;
        public AddStudent()
        {
            InitializeComponent();
            context = new UniversityEntities();
            teachersName = context.Teachers.ToList();
            cathedralsName = context.Cathedras.ToList();
            foreach (Teachers teachers in teachersName)
            {
                comboBox1.Items.Add(teachers.Name);
            }
            //foreach (Cathedras cathedras in cathedralsName)
            //{
            //    comboBox1.Items.Add(cathedras.Name);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Name = textBox1.Text;
            students.Class = textBox3.Text;
            students.Teachers = teachersName[comboBox1.SelectedIndex];
            Cathedras cathedras = (from N in context.Cathedras where N.Id == students.Teachers.Cathedra_Id select N).FirstOrDefault();
            students.Cathedras = cathedras;
            context.Students.Add(students);
            context.SaveChanges();
            Close();
        }
    }
}
