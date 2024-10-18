namespace WindowsFormsApp2
{
    partial class zakaz
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
            this.уП02DataSet = new WindowsFormsApp2.УП02DataSet();
            this.уП02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idлекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idтоварыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имязаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилиязаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествозаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ответсвенныйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колчество1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количество2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявказаказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявка_заказаTableAdapter = new WindowsFormsApp2.УП02DataSetTableAdapters.Заявка_заказаTableAdapter();
            this.Add = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Obnov = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявказаказаBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // уП02DataSet
            // 
            this.уП02DataSet.DataSetName = "УП02DataSet";
            this.уП02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // уП02DataSetBindingSource
            // 
            this.уП02DataSetBindingSource.DataSource = this.уП02DataSet;
            this.уП02DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idзаявкиDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.idлекарстваDataGridViewTextBoxColumn,
            this.idтоварыDataGridViewTextBoxColumn,
            this.имязаказчикаDataGridViewTextBoxColumn,
            this.фамилиязаказчикаDataGridViewTextBoxColumn,
            this.отчествозаказчикаDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.ответсвенныйDataGridViewTextBoxColumn,
            this.колчество1DataGridViewTextBoxColumn,
            this.количество2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заявказаказаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idзаявкиDataGridViewTextBoxColumn
            // 
            this.idзаявкиDataGridViewTextBoxColumn.DataPropertyName = "id_заявки";
            this.idзаявкиDataGridViewTextBoxColumn.HeaderText = "id_заявки";
            this.idзаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idзаявкиDataGridViewTextBoxColumn.Name = "idзаявкиDataGridViewTextBoxColumn";
            this.idзаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // idлекарстваDataGridViewTextBoxColumn
            // 
            this.idлекарстваDataGridViewTextBoxColumn.DataPropertyName = "Id_лекарства";
            this.idлекарстваDataGridViewTextBoxColumn.HeaderText = "Id_лекарства";
            this.idлекарстваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idлекарстваDataGridViewTextBoxColumn.Name = "idлекарстваDataGridViewTextBoxColumn";
            this.idлекарстваDataGridViewTextBoxColumn.Width = 125;
            // 
            // idтоварыDataGridViewTextBoxColumn
            // 
            this.idтоварыDataGridViewTextBoxColumn.DataPropertyName = "Id_товары";
            this.idтоварыDataGridViewTextBoxColumn.HeaderText = "Id_товары";
            this.idтоварыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idтоварыDataGridViewTextBoxColumn.Name = "idтоварыDataGridViewTextBoxColumn";
            this.idтоварыDataGridViewTextBoxColumn.Width = 125;
            // 
            // имязаказчикаDataGridViewTextBoxColumn
            // 
            this.имязаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Имя_заказчика";
            this.имязаказчикаDataGridViewTextBoxColumn.HeaderText = "Имя_заказчика";
            this.имязаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имязаказчикаDataGridViewTextBoxColumn.Name = "имязаказчикаDataGridViewTextBoxColumn";
            this.имязаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилиязаказчикаDataGridViewTextBoxColumn
            // 
            this.фамилиязаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия_заказчика";
            this.фамилиязаказчикаDataGridViewTextBoxColumn.HeaderText = "Фамилия_заказчика";
            this.фамилиязаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилиязаказчикаDataGridViewTextBoxColumn.Name = "фамилиязаказчикаDataGridViewTextBoxColumn";
            this.фамилиязаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествозаказчикаDataGridViewTextBoxColumn
            // 
            this.отчествозаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Отчество_заказчика";
            this.отчествозаказчикаDataGridViewTextBoxColumn.HeaderText = "Отчество_заказчика";
            this.отчествозаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествозаказчикаDataGridViewTextBoxColumn.Name = "отчествозаказчикаDataGridViewTextBoxColumn";
            this.отчествозаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.Width = 125;
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            this.скидкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // ответсвенныйDataGridViewTextBoxColumn
            // 
            this.ответсвенныйDataGridViewTextBoxColumn.DataPropertyName = "Ответсвенный";
            this.ответсвенныйDataGridViewTextBoxColumn.HeaderText = "Ответсвенный";
            this.ответсвенныйDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ответсвенныйDataGridViewTextBoxColumn.Name = "ответсвенныйDataGridViewTextBoxColumn";
            this.ответсвенныйDataGridViewTextBoxColumn.Width = 125;
            // 
            // колчество1DataGridViewTextBoxColumn
            // 
            this.колчество1DataGridViewTextBoxColumn.DataPropertyName = "Колчество1";
            this.колчество1DataGridViewTextBoxColumn.HeaderText = "Колчество1";
            this.колчество1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колчество1DataGridViewTextBoxColumn.Name = "колчество1DataGridViewTextBoxColumn";
            this.колчество1DataGridViewTextBoxColumn.Width = 125;
            // 
            // количество2DataGridViewTextBoxColumn
            // 
            this.количество2DataGridViewTextBoxColumn.DataPropertyName = "Количество2";
            this.количество2DataGridViewTextBoxColumn.HeaderText = "Количество2";
            this.количество2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количество2DataGridViewTextBoxColumn.Name = "количество2DataGridViewTextBoxColumn";
            this.количество2DataGridViewTextBoxColumn.Width = 125;
            // 
            // заявказаказаBindingSource
            // 
            this.заявказаказаBindingSource.DataMember = "Заявка_заказа";
            this.заявказаказаBindingSource.DataSource = this.уП02DataSet;
            // 
            // заявка_заказаTableAdapter
            // 
            this.заявка_заказаTableAdapter.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Century", 7.8F);
            this.Add.Location = new System.Drawing.Point(769, 240);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(111, 48);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Upd
            // 
            this.Upd.Font = new System.Drawing.Font("Century", 7.8F);
            this.Upd.Location = new System.Drawing.Point(769, 297);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(111, 50);
            this.Upd.TabIndex = 2;
            this.Upd.Text = "Изменить";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Century", 7.8F);
            this.Delete.Location = new System.Drawing.Point(769, 354);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 47);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.SteelBlue;
            this.Clear.Font = new System.Drawing.Font("Century", 7.8F);
            this.Clear.Location = new System.Drawing.Point(579, 260);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(119, 48);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 325);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 357);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 407);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(117, 435);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(117, 463);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(117, 501);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(388, 272);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(388, 311);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(388, 366);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(388, 394);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 7.8F);
            this.label1.Location = new System.Drawing.Point(40, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "id_заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 7.8F);
            this.label2.Location = new System.Drawing.Point(72, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 7.8F);
            this.label3.Location = new System.Drawing.Point(17, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "id_лекарства";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 7.8F);
            this.label4.Location = new System.Drawing.Point(38, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "id_товары";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 7.8F);
            this.label5.Location = new System.Drawing.Point(78, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 7.8F);
            this.label6.Location = new System.Drawing.Point(45, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Фамилия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 7.8F);
            this.label7.Location = new System.Drawing.Point(45, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 7.8F);
            this.label8.Location = new System.Drawing.Point(44, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Телефон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 7.8F);
            this.label9.Location = new System.Drawing.Point(318, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Скидка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 7.8F);
            this.label10.Location = new System.Drawing.Point(279, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ответсвенный";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 7.8F);
            this.label11.Location = new System.Drawing.Point(280, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Количество1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 7.8F);
            this.label12.Location = new System.Drawing.Point(279, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Количество2";
            // 
            // Obnov
            // 
            this.Obnov.BackColor = System.Drawing.Color.SteelBlue;
            this.Obnov.Font = new System.Drawing.Font("Century", 7.8F);
            this.Obnov.Location = new System.Drawing.Point(579, 314);
            this.Obnov.Name = "Obnov";
            this.Obnov.Size = new System.Drawing.Size(119, 50);
            this.Obnov.TabIndex = 30;
            this.Obnov.Text = "Обновить";
            this.Obnov.UseVisualStyleBackColor = false;
            this.Obnov.Click += new System.EventHandler(this.Obnov_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Century", 7.8F);
            this.Search.Location = new System.Drawing.Point(782, 33);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 33);
            this.Search.TabIndex = 31;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 709);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Obnov);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "zakaz";
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявказаказаBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private УП02DataSet уП02DataSet;
        private System.Windows.Forms.BindingSource уП02DataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource заявказаказаBindingSource;
        private УП02DataSetTableAdapters.Заявка_заказаTableAdapter заявка_заказаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idлекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idтоварыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имязаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилиязаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествозаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответсвенныйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колчество1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количество2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Obnov;
        private System.Windows.Forms.Button Search;
    }
}