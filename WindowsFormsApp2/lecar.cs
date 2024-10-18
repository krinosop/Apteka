using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class lecar : Form { 

        SqlConnection sqlConnection = new SqlConnection(@" Data Source= DESKTOP-6U7EG8E; Initial catalog=УП02; Integrated Security=True");
        public string TypeUser { get; set; }

    
        public lecar()
        {
            InitializeComponent();
        }

        private void lecar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП02DataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.уП02DataSet.Лекарства);
            StreamReader st = new StreamReader("text.txt");
            string line= st.ReadLine();
            st.Close();

            if(line != "admin")
            {
                Add.Enabled =false;
                Add.Visible = false;

                Upd.Enabled = false;
                Upd.Visible = false;

                Delete.Enabled = false;
                Delete.Visible = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            title form = new title();
 
            form.Show();
            this.Hide();
        }
     
        private void Clear_Click_Click(object sender, EventArgs e)
        {
            textBox1.Text= "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string ComEdit = "INSERT INTO Лекарства (id_лекарсвта, Дата_поставки, Название, Описание, Компоненты, Рецептурность, Цена, Примечание) VALUES (@id, @data, @name, @opic, @comp, @rec, @price, @prim);";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@data", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@name", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@opic", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@comp", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@rec", textBox6.Text);
            SqlParameter pr7 = new SqlParameter("@price", textBox7.Text);
            SqlParameter pr8 = new SqlParameter("@prim", textBox8.Text);


            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);
            cmd1.Parameters.Add(pr7);
            cmd1.Parameters.Add(pr8);


            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            string ComEdit = "UPDATE Лекарства SET id_лекарсвта = @id, Дата_поставки = @data, Название = @name, Описание = @opic, Компоненты = @comp, Рецептурность= @rec, Цена= @price, Примечание=@prim WHERE id_лекарсвта = @id;";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@data", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@name", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@opic", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@comp", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@rec", textBox6.Text);
            SqlParameter pr7 = new SqlParameter("@price", textBox7.Text);
            SqlParameter pr8 = new SqlParameter("@prim", textBox8.Text);

            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);
            cmd1.Parameters.Add(pr7);
            cmd1.Parameters.Add(pr8);

            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ComDel = "Delete from Лекарства where id_лекарсвта = @id";
            SqlCommand cmdDEL = new SqlCommand(ComDel, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);

            cmdDEL.Parameters.Add(pr1);
            sqlConnection.Open();
            cmdDEL.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Obnov_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Лекарства", sqlConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter($"SELECT * FROM Лекарства WHERE id_лекарсвта = {textBox1.Text}", sqlConnection);

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
