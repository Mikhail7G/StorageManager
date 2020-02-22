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
    public partial class UserControl2 : Form
    {

        MySqlDataAdapter adapter;
        DataSet dSet;


        public UserControl2()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            adapter = new MySqlDataAdapter("SELECT idusers, name, passwords, userlevel FROM users", DBConnect.Conn);
            dSet = new DataSet();
            adapter.Fill(dSet, "users");

            dataGridView1.Refresh();
            dataGridView1.DataSource = dSet;
            dataGridView1.DataMember = "users";

           
        }
    }
}
