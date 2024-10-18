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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp2
{
    public partial class sotrud : Form

    {
        SqlConnection sqlConnection = new SqlConnection(@" Data Source= DESKTOP-6U7EG8E; Initial catalog=УП02; Integrated Security=True");
        public string TypeUser { get; set; }
        public sotrud()
        {
            InitializeComponent();
        }

        private void sotrud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП02DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.уП02DataSet.Сотрудники);

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
            form.Show();
        }



        private void Add_Click(object sender, EventArgs e)
        {
            string ComEdit = "INSERT INTO Сотрудники (Id_сотрудника, Фамилия, Имя, Отчество, Паспорт, Возраст, Почта) VALUES (@id, @surname, @name, @ot, @passport, @age, @email);";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@surname", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@name", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@ot", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@passport", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@age", textBox6.Text);
            SqlParameter pr7 = new SqlParameter("@email", textBox7.Text);


            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);
            cmd1.Parameters.Add(pr7);


            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            string ComEdit = "UPDATE Сотрудники SET Id_сотрудника = @id, Фамилия = @surname, Имя = @name, Отчество=@ot, Паспорт=@passport, Возраст=@age, Почта=@email  WHERE Id_сотрудника = @id;";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@surname", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@name", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@ot", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@passport", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@age", textBox6.Text);
            SqlParameter pr7 = new SqlParameter("@email", textBox7.Text);


            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);
            cmd1.Parameters.Add(pr7);


            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ComDel = "Delete from Сотрудники where Id_сотрудника = @id";
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
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Сотрудники", sqlConnection);
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
            textBox7.Text = "";

        }

        private void Search_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter($"SELECT * FROM сотрудники WHERE Id_сотрудника = {textBox1.Text}", sqlConnection);

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }
    }
}
