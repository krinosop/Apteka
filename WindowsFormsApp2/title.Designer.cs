namespace WindowsFormsApp2
{
    partial class title
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
            this.lecar = new System.Windows.Forms.Button();
            this.skid = new System.Windows.Forms.Button();
            this.tovar = new System.Windows.Forms.Button();
            this.sotrud = new System.Windows.Forms.Button();
            this.zakaz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lecar
            // 
            this.lecar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lecar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lecar.Location = new System.Drawing.Point(84, 67);
            this.lecar.Name = "lecar";
            this.lecar.Size = new System.Drawing.Size(169, 76);
            this.lecar.TabIndex = 0;
            this.lecar.Text = "Лекарства";
            this.lecar.UseVisualStyleBackColor = false;
            this.lecar.Click += new System.EventHandler(this.lecar_Click);
            // 
            // skid
            // 
            this.skid.BackColor = System.Drawing.Color.CornflowerBlue;
            this.skid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skid.Location = new System.Drawing.Point(84, 200);
            this.skid.Name = "skid";
            this.skid.Size = new System.Drawing.Size(169, 74);
            this.skid.TabIndex = 1;
            this.skid.Text = "Скидки";
            this.skid.UseVisualStyleBackColor = false;
            this.skid.Click += new System.EventHandler(this.skid_Click);
            // 
            // tovar
            // 
            this.tovar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tovar.Location = new System.Drawing.Point(306, 67);
            this.tovar.Name = "tovar";
            this.tovar.Size = new System.Drawing.Size(157, 76);
            this.tovar.TabIndex = 2;
            this.tovar.Text = "Общие товары";
            this.tovar.UseVisualStyleBackColor = false;
            this.tovar.Click += new System.EventHandler(this.tovar_Click);
            // 
            // sotrud
            // 
            this.sotrud.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sotrud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sotrud.Location = new System.Drawing.Point(306, 200);
            this.sotrud.Name = "sotrud";
            this.sotrud.Size = new System.Drawing.Size(157, 74);
            this.sotrud.TabIndex = 3;
            this.sotrud.Text = "Сотрудники";
            this.sotrud.UseVisualStyleBackColor = false;
            this.sotrud.Click += new System.EventHandler(this.sotrud_Click);
            // 
            // zakaz
            // 
            this.zakaz.BackColor = System.Drawing.Color.CornflowerBlue;
            this.zakaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zakaz.Location = new System.Drawing.Point(547, 138);
            this.zakaz.Name = "zakaz";
            this.zakaz.Size = new System.Drawing.Size(148, 72);
            this.zakaz.TabIndex = 4;
            this.zakaz.Text = "Оформление заказа";
            this.zakaz.UseVisualStyleBackColor = false;
            this.zakaz.Click += new System.EventHandler(this.zakaz_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 365);
            this.Controls.Add(this.zakaz);
            this.Controls.Add(this.sotrud);
            this.Controls.Add(this.tovar);
            this.Controls.Add(this.skid);
            this.Controls.Add(this.lecar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "title";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.title_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lecar;
        private System.Windows.Forms.Button skid;
        private System.Windows.Forms.Button tovar;
        private System.Windows.Forms.Button sotrud;
        private System.Windows.Forms.Button zakaz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
    }
}