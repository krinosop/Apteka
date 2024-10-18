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
    public partial class skid : Form

    {
        SqlConnection sqlConnection = new SqlConnection(@" Data Source= DESKTOP-6U7EG8E; Initial catalog=УП02; Integrated Security=True");
        public string TypeUser { get; set; }
        public skid()
        {
            InitializeComponent();
        }

        private void skid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП02DataSet.Скидка". При необходимости она может быть перемещена или удалена.
            this.скидкаTableAdapter.Fill(this.уП02DataSet.Скидка);

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

    

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            title form = new title();
            form.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }


        private void Add_Click(object sender, EventArgs e)
        {

            string ComEdit = "INSERT INTO Скидка (id_типа, скидка, Категория) VALUES (@id, @skid,@categ);";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@skid", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@categ", textBox3.Text);


            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
   

            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            string ComEdit = "UPDATE Скидка SET id_типа = @id, скидка = @skid, Категория = @id_categ  WHERE id_типа = @id;";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@skid", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@id_categ", textBox3.Text);
  

            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);


            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ComDel = "Delete from Скидка where id_типа = @id";
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
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Скидка", sqlConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter($"SELECT * FROM Скидка WHERE id_типа = {textBox1.Text}", sqlConnection);

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }
    }
}
