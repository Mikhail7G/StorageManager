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
    public partial class componentview : Form
    {
        MySqlDataAdapter adapter;
        DataSet dSet;
        public componentview()
        {
            InitializeComponent();
            GetData();

            this.MinimumSize = new Size(635, 314);
            this.MaximumSize = new Size(638, 317);
        }

        void GetData()
        {//заполняем таблицу на форме, это лучьше первого варианта, наглядно видно все
            adapter = new MySqlDataAdapter("SELECT component.id, component.name, items.name FROM component, items WHERE component.items_id = items.id", DBConnect.Conn);
            dSet = new DataSet();
            adapter.Fill(dSet, "component");

            dataGridView1.Refresh();

            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "component";
            //столбец не нужно показывать, но для удаления необходимо загружать тоже
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Материал";
            dataGridView1.Columns[2].HeaderText = "Группа";
            dataGridView1.Columns[2].ReadOnly = true;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommandBuilder cmb = new MySqlCommandBuilder(adapter);
                adapter.Update(dSet, "component");//обновляем базу данных
                debugTxt.Text = "Обновлено";
                timer1.Enabled = true;
            }
            catch (MySqlException ex)//вывод ошибки подключения
            {
                debugTxt.Text = ex.Message.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            debugTxt.Text = "";
            timer1.Enabled = false;
        }

       // public event System.Windows.Forms.FormClosingEventHandler FormClosing;

        private void componentview_FormClosing(object sender, FormClosingEventArgs e)
        {
            //В случае изменения и не сохранении предупредить пользователя
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
