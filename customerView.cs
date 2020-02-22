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
    public partial class customerView : Form
    {
        public customerView()
        {
            InitializeComponent();
            GetCustomerData();

            this.MinimumSize = new Size(753, 436);
            this.MaximumSize = new Size(755, 437);
        }

        void GetCustomerData()
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dSet;
                adapter = new MySqlDataAdapter("SELECT DISTINCT prodnumber FROM orders", DBConnect.Conn);
                dSet = new DataTable();
                adapter.Fill(dSet);

                customerBox.DataSource = dSet;
                customerBox.DisplayMember = "prodnumber";
                customerBox.ValueMember = "prodnumber";

               
            }
            catch (MySqlException ex)
            {
                debugTxt.Text = ex.Message;
            }
        }

        void GetFullData()
        {
            MySqlDataAdapter adapter;
            DataSet dSet;

            adapter = new MySqlDataAdapter("SELECT orders.date, orders.quantity,users.name, products.name, customers.name, component.name FROM elvestdb.orders, users, products, customers, component, storage WHERE prodnumber = '"+ customerBox .SelectedValue+ "' AND orders.users_idusers = users.idusers AND orders.products_id = products.id AND orders.customers_id = customers.id AND storage.component_id = component.id AND orders.storage_id = storage.id; ", DBConnect.Conn);
            dSet = new DataSet();
            adapter.Fill(dSet, "products");
            dataGridView1.Refresh();

            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "products";
            dataGridView1.Columns[0].HeaderText = "Дата заказа";
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Имя сборщика";
            dataGridView1.Columns[3].HeaderText = "Название продукта";
            dataGridView1.Columns[4].HeaderText = "Имя заказчика";
            dataGridView1.Columns[5].HeaderText = "Название материала";
        }

        private void customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFullData();
        }
    }
}
