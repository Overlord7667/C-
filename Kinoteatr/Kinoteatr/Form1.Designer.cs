
namespace Kinoteatr
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kinoteatrDataSet = new Kinoteatr.KinoteatrDataSet();
            this.kinoteatrDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoteatrDBDataSet = new Kinoteatr.KinoteatrDBDataSet();
            this.kinoteatrFilmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoteatrFilmsTableAdapter = new Kinoteatr.KinoteatrDBDataSetTableAdapters.KinoteatrFilmsTableAdapter();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Kinoteatr.KinoteatrDBDataSetTableAdapters.FilmsTableAdapter();
            this.filmsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrFilmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kinoteatrFilmsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.viewDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(374, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(357, 450);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // kinoteatrDataSet
            // 
            this.kinoteatrDataSet.DataSetName = "KinoteatrDataSet";
            this.kinoteatrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kinoteatrDataSetBindingSource
            // 
            this.kinoteatrDataSetBindingSource.DataSource = this.kinoteatrDataSet;
            this.kinoteatrDataSetBindingSource.Position = 0;
            // 
            // kinoteatrDBDataSet
            // 
            this.kinoteatrDBDataSet.DataSetName = "KinoteatrDBDataSet";
            this.kinoteatrDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kinoteatrFilmsBindingSource
            // 
            this.kinoteatrFilmsBindingSource.DataMember = "KinoteatrFilms";
            this.kinoteatrFilmsBindingSource.DataSource = this.kinoteatrDBDataSet;
            // 
            // kinoteatrFilmsTableAdapter
            // 
            this.kinoteatrFilmsTableAdapter.ClearBeforeFill = true;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.kinoteatrDBDataSet;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // filmsBindingSource1
            // 
            this.filmsBindingSource1.DataMember = "Films";
            this.filmsBindingSource1.DataSource = this.kinoteatrDBDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Number Film";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name Film";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // filmsBindingSource2
            // 
            this.filmsBindingSource2.DataMember = "Films";
            this.filmsBindingSource2.DataSource = this.kinoteatrDBDataSet;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // viewDataGridViewTextBoxColumn
            // 
            this.viewDataGridViewTextBoxColumn.DataPropertyName = "View";
            this.viewDataGridViewTextBoxColumn.HeaderText = "View";
            this.viewDataGridViewTextBoxColumn.Name = "viewDataGridViewTextBoxColumn";
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource
            // 
            this.fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource.DataMember = "FK_dbo.Films_dbo.KinoteatrFilms_KinoteatrFilm_Id";
            this.fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource.DataSource = this.kinoteatrFilmsBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoteatrFilmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource kinoteatrDataSetBindingSource;
        private KinoteatrDataSet kinoteatrDataSet;
        private KinoteatrDBDataSet kinoteatrDBDataSet;
        private System.Windows.Forms.BindingSource kinoteatrFilmsBindingSource;
        private KinoteatrDBDataSetTableAdapters.KinoteatrFilmsTableAdapter kinoteatrFilmsTableAdapter;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private KinoteatrDBDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.BindingSource filmsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource filmsBindingSource2;
        private System.Windows.Forms.BindingSource fKdboFilmsdboKinoteatrFilmsKinoteatrFilmIdBindingSource;
    }
}

