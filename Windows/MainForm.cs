using ElectronicDiary.SqlConnect;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicDiary
{
    public partial class MainForm : Form
    {
        SqlConnector SQL = new SqlConnector();
        public MainForm()
        {
            InitializeComponent();
            InitializeListBoxItems();
        }

        public void  InitializeListBoxItems() 
        {
            string cs = SQL.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                string stm = "SELECT DISTINCT JobTitle FROM Users";
                using (var cmd = new MySqlCommand(stm, con))
                {
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке должностей: {ex.Message}");
            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           string login = LoginBox.Text;
           string Password = PasswordBox.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }
            string cs = SQL.GetConnect();
            try
            {

                using (var con = new MySqlConnection(cs))
                { 
                con.Open();
                string stm = "SELECT * FROM Users WHERE Login = @Login AND Password = @Password";
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке должностей: {ex.Message}");
            }
        }
    }
}
