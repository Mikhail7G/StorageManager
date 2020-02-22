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
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
            GetInitData();
            this.MinimumSize = new Size(410, 270);
            this.MaximumSize = new Size(415, 275);
        }

        void GetInitData()
        {//полуаем начальную инфу при загрузке формы, группы товаров
            try
            {
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
            catch (MySqlException ex)//Ошибки MySql
            {
                debugTxt.Text = ex.Message;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(nameBox.Text !="")
            {
                try
                {
                    string sql = "INSERT INTO component (name, items_id) VALUES ('" + nameBox.Text + "','" + itemTypeBox.SelectedValue.ToString() + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);
                    int numRowsUpdated = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    debugTxt.Text = "Добавлено";
                    nameBox.Text = "";

                    timer1.Enabled = true;

                }
                catch (MySqlException ex)//Ошибки MySql
                {
                    if (ex.Number == 1062)
                    {
                        debugTxt.Text = "Такой компонент уже есть";
                    }
                    else
                    {
                        debugTxt.Text = ex.Message.ToString();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            debugTxt.Text = "";
            timer1.Enabled = false;
        }

        private void allList_Click(object sender, EventArgs e)
        {
            componentview viewf = new componentview();
            viewf.ShowDialog();
        }
    }
}
