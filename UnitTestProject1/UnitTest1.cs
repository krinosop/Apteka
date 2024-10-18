using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace UnitTestProject
{
    [TestClass]
    public partial class UnitTest
    {
        private string connectionString = "Data Source=DESKTOP-6U7EG8E;Initial Catalog=УП02;Integrated Security=True";


        private bool ValidateUserData(string login, string password)
        {
            // Проверка на пустые значения и другие условия валидации
            return !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password);
        }
        [TestMethod]
        public void TestMethod()
        {
            string login = "sotr";
            string password = "321";

            if (!ValidateUserData(login, password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [роль] FROM reg WHERE login=@login AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        string userType = (string)command.ExecuteScalar();

                        if (userType == "admin" || userType == "sotr")
                        {
                            // Запись данных в файл
                            string filePath = "text.txt";
                            File.WriteAllText(filePath, userType);

                            // Открытие новой формы
                            title form = new title();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            string login = "sotr";
            string password = "321";

            if (!ValidateUserData(login, password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [роль] FROM reg WHERE login=@login AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        string userType = (string)command.ExecuteScalar();

                        if (userType == "admin" || userType == "sotr")
                        {
                            // Запись данных в файл
                            string filePath = "text.txt";
                            File.WriteAllText(filePath, userType);

                            // Открытие новой формы
                            title form = new title();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            string login = "sotr";
            string password = "321";

            if (!ValidateUserData(login, password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [роль] FROM reg WHERE login=@login AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        string userType = (string)command.ExecuteScalar();

                        if (userType == "admin" || userType == "sotr")
                        {
                            // Запись данных в файл
                            string filePath = "text.txt";
                            File.WriteAllText(filePath, userType);

                            // Открытие новой формы
                            title form = new title();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            string login = "sotr";
            string password = "321";

            if (!ValidateUserData(login, password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [роль] FROM reg WHERE login=@login AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        string userType = (string)command.ExecuteScalar();

                        if (userType == "admin" || userType == "sotr")
                        {
                            // Запись данных в файл
                            string filePath = "text.txt";
                            File.WriteAllText(filePath, userType);

                            // Открытие новой формы
                            title form = new title();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            string login = "sotr";
            string password = "321";

            if (!ValidateUserData(login, password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [роль] FROM reg WHERE login=@login AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        string userType = (string)command.ExecuteScalar();

                        if (userType == "admin" || userType == "sotr")
                        {
                            // Запись данных в файл
                            string filePath = "text.txt";
                            File.WriteAllText(filePath, userType);

                            // Открытие новой формы
                            title form = new title();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod6()
        {
            string login = "sotr";
            string password = "321";

            if (!ValidateUserData(login, password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [роль] FROM reg WHERE login=@login AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        string userType = (string)command.ExecuteScalar();

                        if (userType == "admin" || userType == "sotr")
                        {
                            // Запись данных в файл
                            string filePath = "text.txt";
                            File.WriteAllText(filePath, userType);

                            // Открытие новой формы
                            title form = new title();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        [TestMethod]

        public void TestMethod7()
        {
            string login = "sotr";
            string password = "321";

            if (!ValidateUserData(login, password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [роль] FROM reg WHERE login=@login AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        string userType = (string)command.ExecuteScalar();

                        if (userType == "admin" || userType == "sotr")
                        {
                            // Запись данных в файл
                            string filePath = "text.txt";
                            File.WriteAllText(filePath, userType);

                            // Открытие новой формы
                            title form = new title();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }


}