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
    public partial class prodList : Form
    {
        MySqlDataAdapter adapter;
        DataSet dSet;
        public prodList()
        {
            InitializeComponent();
            GetData();
            this.MinimumSize = new Size(445, 305);
            this.MaximumSize = new Size(449, 309);
        }

        void GetData()
        {
            adapter = new MySqlDataAdapter("SELECT id, name FROM products", DBConnect.Conn);
            dSet = new DataSet();
            adapter.Fill(dSet, "products");

            dataGridView1.Refresh();

            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "products";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название продукта";


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommandBuilder cmb = new MySqlCommandBuilder(adapter);
                adapter.Update(dSet, "products");
                debugTxt.Text = "Обновлено";
                timer1.Enabled = true;
            }
            catch (MySqlException ex)//вывод ошибки подключения
            {
                debugTxt.Text = ex.Message.ToString();
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

        //public event System.Windows.Forms.FormClosingEventHandler FormClosing;

        private void prodList_FormClosing(object sender, FormClosingEventArgs e)
        {
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
