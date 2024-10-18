namespace WindowsFormsApp2
{
    partial class skid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idтипаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП02DataSet = new WindowsFormsApp2.УП02DataSet();
            this.скидкаTableAdapter = new WindowsFormsApp2.УП02DataSetTableAdapters.СкидкаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear = new System.Windows.Forms.Button();
            this.Obnov = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idтипаDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.скидкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // idтипаDataGridViewTextBoxColumn
            // 
            this.idтипаDataGridViewTextBoxColumn.DataPropertyName = "Id_типа";
            this.idтипаDataGridViewTextBoxColumn.HeaderText = "Id_типа";
            this.idтипаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idтипаDataGridViewTextBoxColumn.Name = "idтипаDataGridViewTextBoxColumn";
            this.idтипаDataGridViewTextBoxColumn.Width = 125;
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "скидка";
            this.скидкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            this.скидкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Width = 125;
            // 
            // скидкаBindingSource
            // 
            this.скидкаBindingSource.DataMember = "Скидка";
            this.скидкаBindingSource.DataSource = this.уП02DataSet;
            // 
            // уП02DataSet
            // 
            this.уП02DataSet.DataSetName = "УП02DataSet";
            this.уП02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // скидкаTableAdapter
            // 
            this.скидкаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "id_типа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Скидка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категория";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(428, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.SteelBlue;
            this.Clear.Location = new System.Drawing.Point(640, 421);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(121, 54);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Obnov
            // 
            this.Obnov.BackColor = System.Drawing.Color.SteelBlue;
            this.Obnov.Location = new System.Drawing.Point(640, 352);
            this.Obnov.Name = "Obnov";
            this.Obnov.Size = new System.Drawing.Size(121, 58);
            this.Obnov.TabIndex = 18;
            this.Obnov.Text = "Обновить";
            this.Obnov.UseVisualStyleBackColor = false;
            this.Obnov.Click += new System.EventHandler(this.Obnov_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(604, 141);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 29);
            this.Search.TabIndex = 17;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(236, 387);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(128, 46);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Upd
            // 
            this.Upd.Location = new System.Drawing.Point(67, 421);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(120, 43);
            this.Upd.TabIndex = 15;
            this.Upd.Text = "Изменить";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(67, 352);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(128, 43);
            this.Add.TabIndex = 14;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // skid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Obnov);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "skid";
            this.Text = "Скидочная программа";
            this.Load += new System.EventHandler(this.skid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private УП02DataSet уП02DataSet;
        private System.Windows.Forms.BindingSource скидкаBindingSource;
        private УП02DataSetTableAdapters.СкидкаTableAdapter скидкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idтипаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Obnov;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Add;
    }
}