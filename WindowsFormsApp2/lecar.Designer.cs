namespace WindowsFormsApp2
{
    partial class lecar
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
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП02DataSet = new WindowsFormsApp2.УП02DataSet();
            this.лекарстваTableAdapter = new WindowsFormsApp2.УП02DataSetTableAdapters.ЛекарстваTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Obnov = new System.Windows.Forms.Button();
            this.Clear_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лекарстваBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.уП02DataSet1 = new WindowsFormsApp2.УП02DataSet();
            this.лекарстваBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.уП02DataSet11 = new WindowsFormsApp2.УП02DataSet1();
            this.уП02DataSet12 = new WindowsFormsApp2.УП02DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idлекарсвтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компонентыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептурностьDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лекарстваBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "Лекарства";
            this.лекарстваBindingSource.DataSource = this.уП02DataSet;
            // 
            // уП02DataSet
            // 
            this.уП02DataSet.DataSetName = "УП02DataSet";
            this.уП02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 23);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 23);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 221);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 23);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(530, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 23);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(530, 79);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(203, 23);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(530, 129);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(203, 23);
            this.textBox8.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Century", 7.8F);
            this.Add.Location = new System.Drawing.Point(23, 444);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(111, 55);
            this.Add.TabIndex = 9;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Upd
            // 
            this.Upd.Font = new System.Drawing.Font("Century", 7.8F);
            this.Upd.Location = new System.Drawing.Point(157, 444);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(115, 55);
            this.Upd.TabIndex = 10;
            this.Upd.Text = "Изменить";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Century", 7.8F);
            this.Delete.Location = new System.Drawing.Point(301, 444);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 55);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Century", 7.8F);
            this.Search.Location = new System.Drawing.Point(793, 212);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(113, 35);
            this.Search.TabIndex = 12;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Obnov
            // 
            this.Obnov.BackColor = System.Drawing.Color.SteelBlue;
            this.Obnov.Font = new System.Drawing.Font("Century", 7.8F);
            this.Obnov.Location = new System.Drawing.Point(783, 424);
            this.Obnov.Name = "Obnov";
            this.Obnov.Size = new System.Drawing.Size(107, 38);
            this.Obnov.TabIndex = 13;
            this.Obnov.Text = "Обновить";
            this.Obnov.UseVisualStyleBackColor = false;
            this.Obnov.Click += new System.EventHandler(this.Obnov_Click);
            // 
            // Clear_Click
            // 
            this.Clear_Click.BackColor = System.Drawing.Color.SteelBlue;
            this.Clear_Click.Font = new System.Drawing.Font("Century", 7.8F);
            this.Clear_Click.Location = new System.Drawing.Point(783, 480);
            this.Clear_Click.Name = "Clear_Click";
            this.Clear_Click.Size = new System.Drawing.Size(107, 37);
            this.Clear_Click.TabIndex = 14;
            this.Clear_Click.Text = "Очистить";
            this.Clear_Click.UseVisualStyleBackColor = false;
            this.Clear_Click.Click += new System.EventHandler(this.Clear_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 7.8F);
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "id_лекарства";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 7.8F);
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата_поставки";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 7.8F);
            this.label3.Location = new System.Drawing.Point(61, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 7.8F);
            this.label4.Location = new System.Drawing.Point(61, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Описание";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 7.8F);
            this.label5.Location = new System.Drawing.Point(46, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Компоненты";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 7.8F);
            this.label6.Location = new System.Drawing.Point(416, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Рецептурность";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 7.8F);
            this.label7.Location = new System.Drawing.Point(484, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Цена";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 7.8F);
            this.label8.Location = new System.Drawing.Point(434, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Примечание";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 27);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // лекарстваBindingSource1
            // 
            this.лекарстваBindingSource1.DataMember = "Лекарства";
            this.лекарстваBindingSource1.DataSource = this.уП02DataSet;
            // 
            // уП02DataSet1
            // 
            this.уП02DataSet1.DataSetName = "УП02DataSet";
            this.уП02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лекарстваBindingSource2
            // 
            this.лекарстваBindingSource2.DataMember = "Лекарства";
            this.лекарстваBindingSource2.DataSource = this.уП02DataSet;
            // 
            // уП02DataSet11
            // 
            this.уП02DataSet11.DataSetName = "УП02DataSet1";
            this.уП02DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // уП02DataSet12
            // 
            this.уП02DataSet12.DataSetName = "УП02DataSet1";
            this.уП02DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idлекарсвтаDataGridViewTextBoxColumn,
            this.датапоставкиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.компонентыDataGridViewTextBoxColumn,
            this.рецептурностьDataGridViewCheckBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.лекарстваBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(64, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(826, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // idлекарсвтаDataGridViewTextBoxColumn
            // 
            this.idлекарсвтаDataGridViewTextBoxColumn.DataPropertyName = "id_лекарсвта";
            this.idлекарсвтаDataGridViewTextBoxColumn.HeaderText = "id_лекарсвта";
            this.idлекарсвтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idлекарсвтаDataGridViewTextBoxColumn.Name = "idлекарсвтаDataGridViewTextBoxColumn";
            this.idлекарсвтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датапоставкиDataGridViewTextBoxColumn
            // 
            this.датапоставкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_поставки";
            this.датапоставкиDataGridViewTextBoxColumn.HeaderText = "Дата_поставки";
            this.датапоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датапоставкиDataGridViewTextBoxColumn.Name = "датапоставкиDataGridViewTextBoxColumn";
            this.датапоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // компонентыDataGridViewTextBoxColumn
            // 
            this.компонентыDataGridViewTextBoxColumn.DataPropertyName = "Компоненты";
            this.компонентыDataGridViewTextBoxColumn.HeaderText = "Компоненты";
            this.компонентыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.компонентыDataGridViewTextBoxColumn.Name = "компонентыDataGridViewTextBoxColumn";
            this.компонентыDataGridViewTextBoxColumn.Width = 125;
            // 
            // рецептурностьDataGridViewCheckBoxColumn
            // 
            this.рецептурностьDataGridViewCheckBoxColumn.DataPropertyName = "Рецептурность";
            this.рецептурностьDataGridViewCheckBoxColumn.HeaderText = "Рецептурность";
            this.рецептурностьDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.рецептурностьDataGridViewCheckBoxColumn.Name = "рецептурностьDataGridViewCheckBoxColumn";
            this.рецептурностьDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            this.примечаниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // лекарстваBindingSource3
            // 
            this.лекарстваBindingSource3.DataMember = "Лекарства";
            this.лекарстваBindingSource3.DataSource = this.уП02DataSet;
            // 
            // lecar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_Click);
            this.Controls.Add(this.Obnov);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "lecar";
            this.Text = "Лекарства";
            this.Load += new System.EventHandler(this.lecar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private УП02DataSet уП02DataSet;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private УП02DataSetTableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Obnov;
        private System.Windows.Forms.Button Clear_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.BindingSource лекарстваBindingSource1;
        private УП02DataSet уП02DataSet1;
        private System.Windows.Forms.BindingSource лекарстваBindingSource2;
        private УП02DataSet1 уП02DataSet11;
        private УП02DataSet1 уП02DataSet12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idлекарсвтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компонентыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn рецептурностьDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource лекарстваBindingSource3;
    }
}