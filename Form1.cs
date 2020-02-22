using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace StorageManager
{
    public partial class Form1 : Form
    {
       
        //данные коннекта к БД
        static string serv = "";
        static string user = "user";
        static string db = "";
        static string port = "";
        static string pass = "";

        public string connStr =
             "server=" + serv.ToString() +
            ";user=" + user.ToString() +
            ";database=" + db.ToString() +
            ";port=" + port.ToString() +
            ";password=" + pass.ToString()+";";

           public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(419, 252);
            this.MaximumSize = new Size(420, 255);
        }



        private void button1_Click(object sender, EventArgs e)
        //подключение к БД
        {
            label1.Text = "Проверка соеденения";
            DBConnect.Conn = new MySqlConnection(connStr);

            try
            {
                DBConnect.Conn.Open();
                label1.Text = "Подключено";

            }
            catch (Exception ex)//вывод ошибки подключения
            {
                label1.Text = ex.Message.ToString();
            }

            label2.Visible = true;//выбор пользователя
            userSelector.Visible = true;

            label3.Visible = true;//ввод пароля
            password.Visible = true;

            loginBtn.Visible = true;//кнопка авторизации
            connectBtn.Visible = false;


            //получаем список пользователей в системе и показываем формы ввода
            string sql = "SELECT name FROM users";
            MySqlCommand command = new MySqlCommand(sql, DBConnect.Conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                // Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                userSelector.Items.Add(reader[0].ToString());
            }
            reader.Close(); // закрываем reader
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userSelector.SelectedItem == null)
            {
                label1.Text = "Выберите пользователя";
            }
            else
            {
                string sql = "SELECT idusers,passwords,userlevel FROM users WHERE name =" + "'" + userSelector.SelectedItem.ToString() + "'";
                try
                {
                    MySqlCommand command = new MySqlCommand(sql, DBConnect.Conn);
                    // MySqlDataReader reader = command.ExecuteReader();
                    MySqlDataReader reader = command.ExecuteReader();

                    string userPass="";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ActiveUser.CurrentUser = Convert.ToInt32(reader[0]);
                            userPass = reader[1].ToString();
                            ActiveUser.UserPrevilegies = Convert.ToInt32(reader[2]);

                        }
                        reader.Close();
                    }

                    if (password.Text.CompareTo(userPass)==0)//проверяем пароль и даем доступ пользователю
                    {
                        label1.Text = "Добро пожалоать";
                        Form mainForm = new Form2();
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        label1.Text = "Неверный пароль";
                    }

                }
                catch (Exception ex)//вывод ошибки подключения
                {
                    label1.Text = ex.Message.ToString();
                }
            }
        }

       
    }
}
