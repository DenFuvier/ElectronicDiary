using ElectronicDiary.Class;
using ElectronicDiary.SqlConnect;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ElectronicDiary
{
    public partial class MainForm : Form
    {
        private string jobTitle;

        public MainForm()
        {
            
            InitializeComponent();
            HelloMessage.Text = "Вход в Электронный дневник" ;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            var sqlConnector = new SqlConnector();
            try
            {
                using (var connection = sqlConnector.OpenConnection())
                {
                    string stm = "SELECT ID , Name , Surname , Patronymic , JobTitle , Login , Password FROM users WHERE Login = @Login AND Password = @Password";
                    using (var command = new MySqlCommand(stm, connection))
                    {
                        command.Parameters.AddWithValue("@Login", Login.Text);
                        command.Parameters.AddWithValue("@Password", Password.Text);


                        using (var reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                int ID = reader.GetInt32(0);
                                string Name = reader.GetString(1);
                                string Surname = reader.GetString(2);
                                string Patronymic = reader.GetString(3);
                                string JobTitle = reader.GetString(4);
                                string Login = reader.GetString(5);
                                string Password = reader.GetString(6);

                                  Users user = new Users(ID, Name, Surname, Patronymic, JobTitle, Login, Password);

                                MessageBox.Show($"Успешно вошли: {Name} {Surname} {Patronymic}");


                                JobTitlelabel.Text = jobTitle;

                               
                                if (JobTitle == "Учитель")
                                {
                                    this.Hide();
                                    Ticher teacherForm = new Ticher(user);
                                    teacherForm.Show();
                                }
                                else
                                {
                                    this.Hide();
                                    Student studentForm = new Student();
                                    studentForm.Show();
                                }
                            }

                        }

                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:{ex.Message}");
            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            //под вопросом 
           
        }
    }
}
