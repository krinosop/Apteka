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
    public partial class zakaz : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@" Data Source= DESKTOP-6U7EG8E; Initial catalog=УП02; Integrated Security=True");
        public string TypeUser { get; set; }
        public zakaz()
        {
            InitializeComponent();
        }

        private void zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП02DataSet.Заявка_заказа". При необходимости она может быть перемещена или удалена.
            this.заявка_заказаTableAdapter.Fill(this.уП02DataSet.Заявка_заказа);
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
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string ComEdit = "INSERT INTO Заявка_заказа (id_заявки, Дата, Id_лекарства, Id_товары, Имя_заказчика, Фамилия_заказчика, Отчество_заказчика, Номер, Скидка, Ответсвенный, Колчество1, Количество2) VALUES (@id, @data, @lecar, @tovar, @name, @surname, @pusname, @nomer,@skid, @otvet, @kol1, @kol2);";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@data", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@lecar", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@tovar", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@name", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@surname", textBox6.Text);
            SqlParameter pr7 = new SqlParameter("@pusname", textBox7.Text);
            SqlParameter pr8 = new SqlParameter("@nomer", textBox8.Text);
            SqlParameter pr9 = new SqlParameter("@skid", textBox9.Text);
            SqlParameter pr10 = new SqlParameter("@otvet", textBox10.Text);
            SqlParameter pr11 = new SqlParameter("@kol1", textBox11.Text);
            SqlParameter pr12 = new SqlParameter("@kol2", textBox12.Text);




            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);
            cmd1.Parameters.Add(pr7);
            cmd1.Parameters.Add(pr8);
            cmd1.Parameters.Add(pr9);
            cmd1.Parameters.Add(pr10);
            cmd1.Parameters.Add(pr11);
            cmd1.Parameters.Add(pr12);



            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            string ComEdit = "UPDATE Заявка_заказа SET id_заявки = @id, Дата = @data, Id_лекарства = @lecar, Id_товары = @tovar, Имя_заказчика = @name, Фамилия_заказчика= @surname, Отчество_заказчика=@pusname, Номер=@nomer, СКидка=@skid, Ответсвенный=@otvet, Колчество1=@kol1, Количество2=@kol2 WHERE id_заявки= = @id;";
            SqlCommand cmd1 = new SqlCommand(ComEdit, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);
            SqlParameter pr2 = new SqlParameter("@data", textBox2.Text);
            SqlParameter pr3 = new SqlParameter("@lecar", textBox3.Text);
            SqlParameter pr4 = new SqlParameter("@tovar", textBox4.Text);
            SqlParameter pr5 = new SqlParameter("@name", textBox5.Text);
            SqlParameter pr6 = new SqlParameter("@surname", textBox6.Text);
            SqlParameter pr7 = new SqlParameter("@pusname", textBox1.Text);
            SqlParameter pr8 = new SqlParameter("@nomer", textBox2.Text);
            SqlParameter pr9 = new SqlParameter("@skid", textBox3.Text);
            SqlParameter pr10 = new SqlParameter("@otvet", textBox4.Text);
            SqlParameter pr11 = new SqlParameter("@kol1", textBox5.Text);
            SqlParameter pr12 = new SqlParameter("@kol2", textBox6.Text);


            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            cmd1.Parameters.Add(pr6);
            cmd1.Parameters.Add(pr7);
            cmd1.Parameters.Add(pr8);
            cmd1.Parameters.Add(pr9);
            cmd1.Parameters.Add(pr10);
            cmd1.Parameters.Add(pr11);
            cmd1.Parameters.Add(pr12);


            sqlConnection.Open();
            cmd1.ExecuteNonQuery();//хуйня ебаная
            sqlConnection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ComDel = "Delete from Заявка_заказа where id_заявки = @id";
            SqlCommand cmdDEL = new SqlCommand(ComDel, sqlConnection);
            SqlParameter pr1 = new SqlParameter("@id", textBox1.Text);

            cmdDEL.Parameters.Add(pr1);
            sqlConnection.Open();
            cmdDEL.ExecuteNonQuery();
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
            textBox8.Text = "";
        }

        private void Obnov_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Заявка_заказа", sqlConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter($"SELECT * FROM Заявка_заказа WHERE id_заявки = {textBox1.Text}", sqlConnection);

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
