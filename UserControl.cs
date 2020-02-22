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
    public partial class UserControl : Form
    {

        List<Users> loadedUsers = new List<Users>();
        int currentSelUser;//текущий выбранный пользователь
        int userLevelPrev;//уровень доступа
        public UserControl()
        {
            InitializeComponent();
            AdminPrevBtn.Checked = true;//скрываем кнопку обновления данных пока не загружены все пользователи
            this.MinimumSize = new Size(306, 451);// размер формы
            this.MaximumSize = new Size(315, 460);

        }


        private void GetUsers()
        {//загружаем пользователей из бд
            try
            {
                loadedUsers.Clear();
                string sql = "SELECT idusers, name, passwords, userlevel FROM users";
                MySqlCommand command = new MySqlCommand(sql, DBConnect.Conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    loadedUsers.Add(new Users { Id = Convert.ToInt32(reader[0].ToString()), Name = reader[1].ToString(), Passwords = reader[2].ToString(), UserLevel = Convert.ToInt32(reader[3].ToString()) });
                }
                reader.Close();

                //сбрасываем дата сорс для нормального добавления компонента в список после создания
                loadedUserSel.DataSource = null;
                loadedUserSel.DataSource = loadedUsers;
                loadedUserSel.DisplayMember = "Name";
                loadedUserSel.ValueMember = "Id";

                UpdateDBBtn.Visible = true;
            }
            catch (Exception ex)//вывод ошибки подключения
            {
                debugLbl.Text = ex.Message.ToString();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // обработчик радиокнопок выбора уровня доступа пользователей
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
               // debugLbl.Text = radioButton.AccessibleName.ToString();
                userLevelPrev = Convert.ToInt32(radioButton.AccessibleName.ToString());
            }
        }

        private void loadedUserSel_SelectedIndexChanged(object sender, EventArgs e)
        {//копируем имя и пароль в формы для  дальейшего редактирования

            if (loadedUserSel.SelectedItem != null)
            {
                currentSelUser = (loadedUserSel.SelectedItem as Users).Id;
                userNameTxt.Text = (loadedUserSel.SelectedItem as Users).Name;
                userPassTxt.Text = (loadedUserSel.SelectedItem as Users).Passwords;

                switch ((loadedUserSel.SelectedItem as Users).UserLevel)
                {
                    case 1:
                        AdminPrevBtn.Checked = true;
                        break;
                    case 2:
                        storageUser.Checked = true;
                        break;
                    case 3:
                        proectBtn.Checked = true;
                        break;
                    case 4:
                        economistBtn.Checked = true;
                        break;
                }
            }

        }

        private void loadFromDB_Click(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void UpdateDBBtn_Click(object sender, EventArgs e)
        {

            UpdateUser();
        }

        void UpdateUser()
        {
            try
            {//выполняем запрос на обновление

                if ((userNameTxt.Text == "") || (userPassTxt.Text == ""))
                {
                    debugLbl.Text = "Не введены данные ";
                }
                else
                { 
                    string sql = "UPDATE users SET name='" + userNameTxt.Text + "',passwords='" + userPassTxt.Text + "',userlevel='" + userLevelPrev + "' WHERE idusers ='" + currentSelUser + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);

                    int numRowsUpdated = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    debugLbl.Text = "Обновлено";

                    //обновляем данные в списке, чтоб корректно отображалось
                    (loadedUserSel.SelectedItem as Users).Name = userNameTxt.Text;
                    (loadedUserSel.SelectedItem as Users).Passwords = userPassTxt.Text;
                    (loadedUserSel.SelectedItem as Users).UserLevel = userLevelPrev;
                }
               
            }
            catch (Exception ex)//вывод ошибки подключения
            {
                debugLbl.Text = ex.Message.ToString();
            }

        }

        private void addNewUserBtn_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        void AddUser()
        {
            try
            {

                if ((userNameTxt.Text == "")|| (userPassTxt.Text == ""))
                {
                    debugLbl.Text = "Заполните все поля";
                }
                else
                {

                    string sql = "INSERT INTO users (name, passwords, userlevel) VALUES ('" + userNameTxt.Text + "','" + userPassTxt.Text + "','" + userLevelPrev + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);
                    cmd.ExecuteNonQuery();
                   
                    debugLbl.Text = "Пользователь добавлен";

                    GetUsers();
                }
            }
            catch (MySqlException ex)//Ошибки MySql
            {

                if (ex.Number == 1062)
                {
                    debugLbl.Text = "Такой пользователь есть";
                }
                else
                {
                    debugLbl.Text = ex.Message.ToString();
                }

                   
            }
        }
    }

    public class Users
    {//данные пользователей
        public int Id { get; set; }
        public string Name { get; set; }
        public string Passwords { get; set; }
        public int UserLevel { get; set; }
    }
}
