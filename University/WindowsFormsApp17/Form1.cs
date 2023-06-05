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
    public partial class Form1 : Form
    {
        Teachers teachers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.universityDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.universityDataSet.Teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityDataSet.Cathedras". При необходимости она может быть перемещена или удалена.
            this.cathedrasTableAdapter.Fill(this.universityDataSet.Cathedras);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.ShowDialog();
            addTeacher.ShowDialog();
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UniversityEntities context = new UniversityEntities();
            Teachers teachers = (from T in context.Teachers where T.Name.Contains(dataGridView2.CurrentCell.Value.ToString()) select T).FirstOrDefault();
            context.Teachers.Remove(teachers);
            context.SaveChanges();
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UniversityEntities context = new UniversityEntities();
            Teachers t = context.Teachers.Find(teachers.id);
            t.Name = dataGridView2.CurrentCell.Value.ToString();
            context.SaveChanges();
            dataGridView2.Refresh();
            Application.Restart();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UniversityEntities context = new UniversityEntities();
            if (e.ColumnIndex==0)
            teachers = (from T in context.Teachers where T.Name.Contains(dataGridView2.CurrentCell.Value.ToString()) select T).FirstOrDefault();
        }
    }
}
