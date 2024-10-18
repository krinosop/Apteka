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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dop_v()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user_type;
            using (SqlConnection sqlConnection = new SqlConnection(@" Data Source= DESKTOP-6U7EG8E; Initial catalog=УП02; Integrated Security=True")) {
                sqlConnection.Open();
                SqlCommand com =  new SqlCommand("Select [роль] FROM reg Where login=@login and password=@password", sqlConnection);
                SqlParameter pr1 = new SqlParameter("@login", textBox1.Text);
                SqlParameter pr2 = new SqlParameter("@password", textBox2.Text);

                com.Parameters.Add(pr1);
                com.Parameters.Add(pr2);

                user_type = (string)com.ExecuteScalar();

                string pas = "text.txt";
                StreamWriter sw = new StreamWriter(pas, false);
                sw.WriteLine(user_type);
                sw.Close();
            }
            if(user_type !="admin" &&  user_type != "sotr") {

                MessageBox.Show("Перепроверьте данные, неверные логин или пароль!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else {

                title form = new title();
                form.Show();
                this.Hide();
            }

        }

 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
