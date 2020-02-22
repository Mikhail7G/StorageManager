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
    public partial class Storage : Form
    {
        List<ItemCats> itemsCat = new List<ItemCats>();

        public Storage()
        {
            InitializeComponent();
            // GetData();//получаем необходимые данные
            GetInitData();
            GetItemsByCat();
            this.MinimumSize = new Size(578, 241);
            this.MaximumSize = new Size(580, 245);

            if (ActiveUser.UserPrevilegies == 1)
                viewBtn.Visible = true;



            //dateForm.Format = DateTimePickerFormat.Custom;
            //dateForm.CustomFormat = "yyyy MM dd";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;//вводим только цифры
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        void GetInitData()
        {//полуаем начальную инфу при загрузке формы, группы товаров
            MySqlDataAdapter adapter;
            DataTable dSet;
            adapter = new MySqlDataAdapter("SELECT id, name FROM items", DBConnect.Conn);
            dSet = new DataTable();
            adapter.Fill(dSet);
           
            itemTypeBox.DataSource = dSet;
            itemTypeBox.DisplayMember = "name";
            itemTypeBox.ValueMember = "id";

            debugTxt.Text = "Заполните поля";
       
        }

        [Obsolete]
        public void GetData()
        {
            try
            {
                string sql = "SELECT id, name FROM items";
                MySqlCommand command = new MySqlCommand(sql, DBConnect.Conn);
                MySqlDataReader reader = command.ExecuteReader();

                itemsCat.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        itemsCat.Add(new ItemCats { Id = Convert.ToInt32(reader[0].ToString()), Name = reader[1].ToString() });
                    }
                    reader.Close();

                    itemTypeBox.DataSource = itemsCat;
                    itemTypeBox.DisplayMember = "name";
                    itemTypeBox.ValueMember = "id";

                    debugTxt.Text = "Заполните поля";

                    label6.Text = ActiveUser.CurrentUser.ToString();//для отладки
 
                }

            }
            catch (MySqlException ex)//Ошибки MySql
            {
                debugTxt.Text = ex.Message;
            }
        }

        void AddData()
        {
            if((quantBox.Text == "")||(docBox.Text == "")||(storagePos.Text == ""))
            {
                debugTxt.Text = "Заполните все поля!";
            }
            else
            {
               try
                {         
                    if (itemSelector.SelectedItem == null)
                    {
                        debugTxt.Text = "Не выбран компонент";
                    }
                    else
                    {
                        string sql = "INSERT INTO storage (quantity, date, document, storagepoz, users_idusers, component_id, rezerved) VALUES('" + quantBox.Text + "','" + dateForm.Text + "','" + docBox.Text + "','" + storagePos.Text + "','" + ActiveUser.CurrentUser + "','" + itemSelector.SelectedValue.ToString() + "','0') ";
                        MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);
                        cmd.ExecuteNonQuery();
                        debugTxt.Text = "Добавлено успешно";
                    }

                    ClearInput();
                }
                catch (MySqlException ex)//Ошибки MySql
                {
                    debugTxt.Text = ex.Message;
                }
            }
        }
        void GetItemsByCat()
        {//загрузка объектов по фильтру категорий
            MySqlDataAdapter a;
            DataTable ds;
            try
            {
                a = new MySqlDataAdapter("SELECT id, name FROM component WHERE items_id = '" + itemTypeBox.SelectedValue.ToString() + "'", DBConnect.Conn);
                ds = new DataTable();
                a.Fill(ds);

                itemSelector.Update();
                itemSelector.SelectedItem = null;
                itemSelector.DataSource = ds;
                itemSelector.DisplayMember = "name";
                itemSelector.ValueMember = "id";

               
            }
            catch (MySqlException ex)//Ошибки MySql
            {
                debugTxt.Text = ex.Message;
            }
        }

        void ClearInput()
        {//очищаем форму          
            quantBox.Text = "";
            docBox.Text = "";
            storagePos.Text = "";
            timer1.Enabled = true;
        }

       
        private void dateForm_ValueChanged(object sender, EventArgs e)
        {
           label6.Text = dateForm.Text;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddData();
            
        }

        private void ClearText(object sender, EventArgs e)
        {
            debugTxt.Text = "";
            timer1.Enabled = false;
        }

        private void itemTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetItemsByCat();
          
        }

        private void itemSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
           // debugTxt.Text = itemSelector.Text;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            storageView comvw = new storageView();
            comvw.ShowDialog();
        }
    }
}
