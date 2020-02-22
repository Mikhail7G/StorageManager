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
    public partial class customers : Form
    {
        MySqlDataAdapter adapter;
        DataSet dSet;
        public customers()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            adapter = new MySqlDataAdapter("SELECT * FROM customers", DBConnect.Conn);
            dSet = new DataSet();
            adapter.Fill(dSet, "customers");

            dataGridView1.Refresh();

            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "customers";
            //столбец не нужно показывать, но для удаления необходимо загружать тоже
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";

            debugTxt.Text = "Заполните все поля";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommandBuilder cmb = new MySqlCommandBuilder(adapter);
                adapter.Update(dSet, "customers");//обновляем базу данных
                debugTxt.Text = "Обновлено";
                timer1.Enabled = true;
            }
            catch (MySqlException ex)//вывод ошибки подключения
            {
                debugTxt.Text = ex.Message;
                if (ex.Number == 1364)
                    debugTxt.Text = "Заполните все поля";
                if (ex.Number == 1062)
                    debugTxt.Text = "Дублирующие данные";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            debugTxt.Text = "";
            timer1.Enabled = false;
        }

        private void customers_FormClosing(object sender, FormClosingEventArgs e)
        {//В случае изменения и не сохранении предупредить пользователя
            if (dSet.HasChanges())
            {
                if (MessageBox.Show("Вы не сохранили данные? Ок- выйти без сохранения", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                   
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
