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
    public partial class storageView : Form
    {
        MySqlDataAdapter adapter;
        DataSet dSet;
        public storageView()
        {
            InitializeComponent();
            GetData();
            this.MinimumSize = new Size(700, 345);
            this.MaximumSize = new Size(705, 348);
        }

        void GetData()
        {
            //это пойдет для месачного отчета
            // adapter = new MySqlDataAdapter("SELECT storage.id, storage.quantity, storage.rezerved , users.name, component.name, storage.date FROM elvestdb.storage, users, component WHERE storage.users_idusers = users.idusers AND date between '"+ dateTimePicker1 .Text+ "' AND last_day('" + dateTimePicker1.Text + "') AND storage.component_id = component.id; ", DBConnect.Conn);
            adapter = new MySqlDataAdapter("SELECT storage.id, storage.quantity, storage.rezerved , users.name, component.name, storage.date, storage.storagepoz, items.name FROM elvestdb.storage, users, component, items WHERE storage.users_idusers = users.idusers AND date between '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND storage.component_id = component.id AND component.items_id = items.id; ", DBConnect.Conn);
            dSet = new DataSet();
            adapter.Fill(dSet, "storage");

            dataGridView1.Refresh();

            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "storage";
            //столбец не нужно показывать, но для удаления необходимо загружать тоже
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Использованно";
            dataGridView1.Columns[3].HeaderText = "Кто добавил";
            dataGridView1.Columns[4].HeaderText = "Название материала";
            dataGridView1.Columns[5].HeaderText = "Дата поставки";
            dataGridView1.Columns[6].HeaderText = "Место хранения";
            dataGridView1.Columns[7].HeaderText = "Группа";


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            GetData();
        }
    }
}
