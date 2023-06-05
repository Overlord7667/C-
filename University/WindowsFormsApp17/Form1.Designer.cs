
namespace WindowsFormsApp17
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cathedrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet = new WindowsFormsApp17.UniversityDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.cathedrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cathedrasTableAdapter = new WindowsFormsApp17.UniversityDataSetTableAdapters.CathedrasTableAdapter();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new WindowsFormsApp17.UniversityDataSetTableAdapters.TeachersTableAdapter();
            this.teachersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cathedraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKdboStudentsdboTeachersTeacheridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fKdboStudentsdboCathedrasCathedraIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new WindowsFormsApp17.UniversityDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboStudentsdboTeachersTeacheridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboStudentsdboCathedrasCathedraIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cathedrasBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(105, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cathedrasBindingSource1
            // 
            this.cathedrasBindingSource1.DataMember = "Cathedras";
            this.cathedrasBindingSource1.DataSource = this.universityDataSet;
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.bdayDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKdboTeachersdboCathedrasCathedraIdBindingSource6;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(105, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(273, 408);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 120;
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "Bday";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "День рождения";
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            // 
            // fKdboTeachersdboCathedrasCathedraIdBindingSource6
            // 
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource6.DataMember = "FK_dbo.Teachers_dbo.Cathedras_Cathedra_Id";
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource6.DataSource = this.cathedrasBindingSource1;
            // 
            // cathedrasBindingSource
            // 
            this.cathedrasBindingSource.DataMember = "Cathedras";
            this.cathedrasBindingSource.DataSource = this.universityDataSet;
            // 
            // cathedrasTableAdapter
            // 
            this.cathedrasTableAdapter.ClearBeforeFill = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.universityDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teachersBindingSource1
            // 
            this.teachersBindingSource1.DataMember = "Teachers";
            this.teachersBindingSource1.DataSource = this.universityDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(378, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 29);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Изменить данные учителя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить студента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить Преподавателя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить Преподавателя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.cathedraIdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fKdboStudentsdboTeachersTeacheridBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(378, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(579, 360);
            this.dataGridView3.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // cathedraIdDataGridViewTextBoxColumn
            // 
            this.cathedraIdDataGridViewTextBoxColumn.DataPropertyName = "Cathedra_Id";
            this.cathedraIdDataGridViewTextBoxColumn.HeaderText = "Cathedra_Id";
            this.cathedraIdDataGridViewTextBoxColumn.Name = "cathedraIdDataGridViewTextBoxColumn";
            // 
            // fKdboStudentsdboTeachersTeacheridBindingSource
            // 
            this.fKdboStudentsdboTeachersTeacheridBindingSource.DataMember = "FK_dbo.Students_dbo.Teachers_Teacher_id";
            this.fKdboStudentsdboTeachersTeacheridBindingSource.DataSource = this.fKdboTeachersdboCathedrasCathedraIdBindingSource6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Студенты";
            // 
            // fKdboStudentsdboCathedrasCathedraIdBindingSource
            // 
            this.fKdboStudentsdboCathedrasCathedraIdBindingSource.DataMember = "FK_dbo.Students_dbo.Cathedras_Cathedra_Id";
            this.fKdboStudentsdboCathedrasCathedraIdBindingSource.DataSource = this.cathedrasBindingSource1;
            // 
            // fKdboTeachersdboCathedrasCathedraIdBindingSource
            // 
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource.DataMember = "FK_dbo.Teachers_dbo.Cathedras_Cathedra_Id";
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource.DataSource = this.cathedrasBindingSource;
            // 
            // fKdboTeachersdboCathedrasCathedraIdBindingSource1
            // 
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource1.DataMember = "FK_dbo.Teachers_dbo.Cathedras_Cathedra_Id";
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource1.DataSource = this.cathedrasBindingSource;
            // 
            // fKdboTeachersdboCathedrasCathedraIdBindingSource2
            // 
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource2.DataMember = "FK_dbo.Teachers_dbo.Cathedras_Cathedra_Id";
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource2.DataSource = this.cathedrasBindingSource;
            // 
            // fKdboTeachersdboCathedrasCathedraIdBindingSource3
            // 
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource3.DataMember = "FK_dbo.Teachers_dbo.Cathedras_Cathedra_Id";
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource3.DataSource = this.cathedrasBindingSource;
            // 
            // fKdboTeachersdboCathedrasCathedraIdBindingSource4
            // 
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource4.DataMember = "FK_dbo.Teachers_dbo.Cathedras_Cathedra_Id";
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource4.DataSource = this.cathedrasBindingSource;
            // 
            // fKdboTeachersdboCathedrasCathedraIdBindingSource5
            // 
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource5.DataMember = "FK_dbo.Teachers_dbo.Cathedras_Cathedra_Id";
            this.fKdboTeachersdboCathedrasCathedraIdBindingSource5.DataSource = this.cathedrasBindingSource;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.universityDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboStudentsdboTeachersTeacheridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboStudentsdboCathedrasCathedraIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboTeachersdboCathedrasCathedraIdBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource cathedrasBindingSource;
        private UniversityDataSetTableAdapters.CathedrasTableAdapter cathedrasTableAdapter;
        private System.Windows.Forms.BindingSource fKdboTeachersdboCathedrasCathedraIdBindingSource;
        private System.Windows.Forms.BindingSource cathedrasBindingSource1;
        private System.Windows.Forms.BindingSource fKdboTeachersdboCathedrasCathedraIdBindingSource1;
        private System.Windows.Forms.BindingSource fKdboTeachersdboCathedrasCathedraIdBindingSource2;
        private System.Windows.Forms.BindingSource fKdboTeachersdboCathedrasCathedraIdBindingSource3;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private UniversityDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource fKdboTeachersdboCathedrasCathedraIdBindingSource4;
        private System.Windows.Forms.BindingSource teachersBindingSource1;
        private System.Windows.Forms.BindingSource fKdboTeachersdboCathedrasCathedraIdBindingSource5;
        private System.Windows.Forms.BindingSource fKdboTeachersdboCathedrasCathedraIdBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cathedraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKdboStudentsdboCathedrasCathedraIdBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private UniversityDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource fKdboStudentsdboTeachersTeacheridBindingSource;
        private System.Windows.Forms.Button button4;
    }
}

