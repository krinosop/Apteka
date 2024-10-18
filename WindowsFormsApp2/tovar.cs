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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class tovar : Form
    {

        SqlConnection sqlConnection = new SqlConnection(@" Data Source= DESKTOP-6U7EG8E; Initial catalog=УП02; Integrated Security=True");
        public string TypeUser { get; set; }
        public tovar()
        {
            InitializeComponent();
        }

        private void tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП02DataSet.Общие_товары". При необходимости она может быть перемещена или удалена.
            this.общие_товарыTableAdapter.Fill(this.уП02DataSet.Общие_товары);
            StreamReader st = new StreamReader("text.txt");
            string line = st.ReadLine();
            st.Close();

            if (line != "admin")
            {
                Add.Enabled = false;
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
            form.Show();        }


        private void Add_Click(object sender, EventArgs e)
        {
            string ComEdit = "INSERT INTO Общие_товары (Id_товары, Название, Описание, Дата_поставки, Примечание, Цена) VALUES (@id, @name, @opic, @data, @prim, @price);";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@name", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@opic", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@data", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@prim", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@price", textBox6.Text);
      


            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);
  


            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            string ComEdit = "UPDATE Лекарства SET Id_товары = @id, Название = @name, Описание = @opic, Дата_поставки = @data, Примечание=@prim, Цена= @price  WHERE Id_товары = @id;";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@name", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@opic", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@data", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@prim", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@price", textBox6.Text);



            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);


            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ComDel = "Delete from Общие_товары where Id_товары = @id";
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
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Общие_товары", sqlConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
         
        }

        private void Search_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter($"SELECT * FROM Общие_товары WHERE Id_njdfhs = {textBox1.Text}", sqlConnection);

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }
    }
}
