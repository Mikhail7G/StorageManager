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
{//данная форма не нежна
    [Obsolete]
    public partial class ItemManager : Form
    {

        List<ItemCats> itemsCat = new List<ItemCats>();
        int currentIndex = 0;
        public ItemManager()
        {
            InitializeComponent();
            this.MinimumSize = new Size(298,348);
            this.MaximumSize = new Size(300, 360);

        }


        void LoadData()
        {
            try
            {
                string sql = "SELECT id, name FROM items";
                MySqlCommand command = new MySqlCommand(sql, DBConnect.Conn);
                MySqlDataReader reader = command.ExecuteReader();

                itemsCat.Clear();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        itemsCat.Add(new ItemCats { Id = Convert.ToInt32(reader[0].ToString()), Name = reader[1].ToString() });
                    }
                    
                }
                reader.Close();

                catListSel.DataSource = null;
                catListSel.DataSource = itemsCat;
                catListSel.DisplayMember = "name";
                catListSel.ValueMember = "id";

                debugTxt.Text = "Загруженно";

                updateBtn.Visible = true;
                insertBtn.Visible = true;


            }
            catch (MySqlException ex)//Ошибки MySql
            {
                debugTxt.Text = ex.Message;
            }
        }

        void UpdateData()
        {
            try
            {
                if(nameBox.Text !="")
                {
                    string sql = "UPDATE items SET name='"+nameBox.Text+"' WHERE id ='"+currentIndex+"'";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);
                    int numRowsUpdated = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    (catListSel.SelectedItem as ItemCats).Name = nameBox.Text;

                    debugTxt.Text = "Обновлено";
                }
                else
                {
                    debugTxt.Text = "Введите имя";
                }

            }
            catch (MySqlException ex)//Ошибки MySql
            {
                if (ex.Number == 1062)
                {
                    debugTxt.Text = "Такая категория есть";
                }
                else
                {
                    debugTxt.Text = ex.Message.ToString();
                }
            }
        }

        void AddData()
        {
            try
            {
                if(nameBox.Text != "")
                {
                    string sql = "INSERT INTO items (name) VALUES('"+nameBox.Text+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);
                    cmd.ExecuteNonQuery();

                    debugTxt.Text = "Данные добавлены";
                    //обновляем 
                    LoadData();
                }

            }
            catch (MySqlException ex)//Ошибки MySql
            {
                if (ex.Number == 1062)
                {
                    debugTxt.Text = "Такая категория есть";
                }
                else
                {
                    debugTxt.Text = ex.Message.ToString();
                }
            }
        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void catListSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(catListSel.SelectedItem != null)
            {
                currentIndex = (catListSel.SelectedItem as ItemCats).Id;
                nameBox.Text = (catListSel.SelectedItem as ItemCats).Name;
            }
            debugTxt.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }

   

}
