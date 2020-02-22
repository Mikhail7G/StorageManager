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
    public partial class Product : Form
    {
        MySqlDataAdapter a;
        DataTable ds;

        int selectedItemQuantity;
        int currentProdIndex;//текущий индекс готового компонента


        List<string> commands = new List<string>();
        public bool formClosedBeforeSave = false;

        struct UpdatedStr
        {
            public int Id { get; set; }
            public int Rezerved { get; set; }

        }

        List<UpdatedStr> continedCommands = new List<UpdatedStr>();//спискок всех комманд, которые можно будет откатить в случае не сохранения пользователем


        MySqlTransaction sqlTran;
        MySqlCommand MyCommand = DBConnect.Conn.CreateCommand();

        public Product()
        {
            InitializeComponent();
            GetInitData();
            GetProdNames();
            this.MinimumSize = new Size(689, 406);
            this.MaximumSize = new Size(690, 410);
        }

        void ClearAllData()
        {
            commands.Clear();
            continedCommands.Clear();
            dataGridView1.Rows.Clear();
        }

        void GetInitData()
        {//полуаем начальную инфу при загрузке формы, группы товаров
            MySqlDataAdapter adapter;
            DataTable dSet;
            adapter = new MySqlDataAdapter("SELECT id, name FROM items", DBConnect.Conn);
            dSet = new DataTable();
            adapter.Fill(dSet);

            prodCombo.DataSource = dSet;
            prodCombo.DisplayMember = "name";
            prodCombo.ValueMember = "id";

            MySqlDataAdapter ad;
            DataTable ds;
            ad = new MySqlDataAdapter("SELECT id, name FROM customers", DBConnect.Conn);
            ds = new DataTable();
            ad.Fill(ds);

            customerTxt.DataSource = ds;
            customerTxt.DisplayMember = "name";
            customerTxt.ValueMember = "id";

            dataGridView1.Columns.Add("name", "Компонент");
            dataGridView1.Columns.Add("quant", "Колчиество");
            dataGridView1.Columns.Add("doc", "№ накладной");


        }
        [Obsolete]
        void GetItemsByCat()
        {//загрузка объектов по фильтру категорий
            MySqlDataAdapter a;
            DataTable ds;
            try
            {

                a = new MySqlDataAdapter("SELECT id, name FROM component WHERE items_id = '" + prodCombo.SelectedValue.ToString() + "'", DBConnect.Conn);
                ds = new DataTable();
                a.Fill(ds);

                CompBox.Update();
                CompBox.SelectedItem = null;
                CompBox.DataSource = ds;
                CompBox.DisplayMember = "name";
                CompBox.ValueMember = "id";
            }
            catch (MySqlException ex)//Ошибки MySql
            {
                debugTxt.Text = ex.Message;
            }
        }

        void GetItems(string from)
        {
            //MySqlDataAdapter a;
            //DataTable ds;
            try
            {

                a = new MySqlDataAdapter("SELECT id, name FROM component WHERE items_id = '" + from + "'", DBConnect.Conn);
                ds = new DataTable();
                a.Fill(ds);


            }
            catch (MySqlException ex)//Ошибки MySql
            {
                debugTxt.Text = ex.Message;
            }

        }
        private void prodCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // debugTxt.Text = prodCombo.SelectedValue.ToString() ;
            //GetItemsByCat();
            GetItems(prodCombo.SelectedValue.ToString());

            CompBox.Update();
            CompBox.SelectedItem = null;
            CompBox.DataSource = ds;
            CompBox.DisplayMember = "name";
            CompBox.ValueMember = "id";
        }

        void UpdateQuant()
        {//общее количество остатка на складе по выбранному компоненту
            if (CompBox.SelectedItem != null)
            {
                try
                {
                    string sql = "SELECT sum(quantity-rezerved) FROM storage WHERE component_id = '" + CompBox.SelectedValue.ToString() + "'";
                    MySqlCommand command = new MySqlCommand(sql, DBConnect.Conn);
                    quantLbl.Text = command.ExecuteScalar().ToString();

                    if (quantLbl.Text == "")
                    {
                        quantLbl.Text = "Отсутствует";
                    }
                    else
                    {
                        selectedItemQuantity = Convert.ToInt32(quantLbl.Text);
                    }

                }
                catch (MySqlException ex)
                {
                    debugTxt.Text = ex.Message;
                }
            }
            else
            {
                selectedItemQuantity = 0;
                quantLbl.Text = "Отсутствует";
            }
        }
        private void CompBox0_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateQuant();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            formClosedBeforeSave = true;
            UpdateQuant();

            int selectedQuant = 0;

            if (quantTxt.Text != "")
                selectedQuant = Convert.ToInt32(quantTxt.Text);

            if (selectedQuant > selectedItemQuantity)
            {
                debugTxt.Text = "Внимание! на скаде запасов менльше желаемого!";
                timer1.Enabled = true;
            }
            else
            {

                if (CompBox.SelectedItem != null)
                {
                    if (Convert.ToInt32(quantTxt.Text) > 0)
                    {

                        try
                        {
                            string sql = "SELECT id,quantity,rezerved,document FROM storage WHERE component_id = '" + CompBox.SelectedValue.ToString() + "'";
                            MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);
                            MySqlDataReader rdr = cmd.ExecuteReader();

                            if (rdr.HasRows)//наличие строк, если данные найдены, то обратываем
                            {//тут идет проверка на наличие объектов на складе
                             //если в партии осталось материалов меньше чем надо,
                             // поиск идет по другим записям для формирования заказа
                                while (rdr.Read())
                                {
                                    int q, r, delta, id, doc;
                                    q = Convert.ToInt32(rdr[1].ToString());
                                    r = Convert.ToInt32(rdr[2].ToString());
                                    doc = Convert.ToInt32(rdr[3].ToString());
                                    delta = q - r;

                                    if (selectedQuant <= delta)
                                    {//если в найденной записи достаточно компонентов то просто вносим запись о этом
                                     //иначе остаток берем из следующей, если материала нехаватает то ничего не делаем, уведомляем пользователя об этом
                                        id = Convert.ToInt32(rdr[0].ToString());
                                        rdr.Close();

                                        UpdateTable(selectedQuant, id, doc);
                                        break;
                                    }
                                    else
                                    {
                                        if (delta > 0)
                                        {
                                            selectedQuant -= delta;
                                            id = Convert.ToInt32(rdr[0].ToString());

                                            UpdateTable(delta, id, doc);
                                        }
                                    }

                                }
                                rdr.Close();
                                ExecAll();

                            }
                        }
                        catch (MySqlException ex)
                        {
                            debugTxt.Text = ex.Message;
                        }
                    }
                }
                else
                {
                    debugTxt.Text = "Укажите количество материала";
                }
            }

        }
        void ExecAll()
        {//как только сформировался заказ, все необходимые запросы отправляем в БД
         //используем механиз транзакций, защищает от множественного доступа к полям


            sqlTran = DBConnect.Conn.BeginTransaction(System.Data.IsolationLevel.Serializable);
            MyCommand.Transaction = sqlTran;


            try
            {
                foreach (string c in commands)
                {
                    //MySqlCommand cmd = new MySqlCommand(c, DBConnect.Conn);

                    //int numRowsUpdated = cmd.ExecuteNonQuery();
                    //cmd.Dispose();
                    MyCommand.CommandText = c;
                    MyCommand.ExecuteNonQuery();

                }
                sqlTran.Commit();
                commands.Clear();
            }
            catch (MySqlException ex)
            {
                debugTxt.Text = ex.Message;
                sqlTran.Rollback();
            }

            debugTxt.Text = "Компоненты зарезирвированны";
            timer1.Enabled = true;

            UpdateQuant();
        }
        void UpdateTable(int _r, int _id, int _d)
        {//бронирование компонентов для заказа
            try
            {
                int t;
                t = Math.Min(Convert.ToInt32(quantTxt.Text), _r);

                string sql = "UPDATE storage SET rezerved = rezerved + '" + _r.ToString() + "' WHERE id = '" + _id.ToString() + "' ";
                commands.Add(sql);
                continedCommands.Add(new UpdatedStr { Id = _id, Rezerved = t });

                dataGridView1.Rows.Add(CompBox.Text, t.ToString(), _d.ToString());
            }
            catch (MySqlException ex)
            {
                debugTxt.Text = ex.Message;
            }
        }

        private void quantTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;//вводим только цифры
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            debugTxt.Text = "";
            timer1.Enabled = false;
        }

        private void IntertBtn_Click(object sender, EventArgs e)
        {
            formClosedBeforeSave = false;
            timer1.Enabled = true;
            debugTxt.Text = "Заказ успешно сформирован";


            InsertOrderList();
            ClearAllData();

        }


        void RollbackAll()
        {//отменяем все запрошенные компоненты

            try
            {
                foreach (UpdatedStr st in continedCommands)
                {
                    string c = "UPDATE storage SET rezerved = rezerved - '" + st.Rezerved.ToString() + "' WHERE id = '" + st.Id.ToString() + "' ";
                    MySqlCommand cmd = new MySqlCommand(c, DBConnect.Conn);

                    int numRowsUpdated = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                continedCommands.Clear();
                formClosedBeforeSave = false;
                dataGridView1.Rows.Clear();
            }
            catch (MySqlException ex)
            {
                debugTxt.Text = ex.Message;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            RollbackAll();
        }

        // public event System.Windows.Forms.FormClosingEventHandler FormClosing;
        private void Product_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClosedBeforeSave)
            {
                if (MessageBox.Show("Вы не сохранили данные? Ок- выйти без сохранения", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    RollbackAll();
                }
                else
                {

                    e.Cancel = true;
                }
            }
        }

        void GetProdNames()
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dSet;
                adapter = new MySqlDataAdapter("SELECT id, name FROM products", DBConnect.Conn);
                dSet = new DataTable();
                adapter.Fill(dSet);

                prodNameBox.DataSource = dSet;
                prodNameBox.DisplayMember = "name";
                prodNameBox.ValueMember = "id";

                GetUniqIndex();
            }
            catch (MySqlException ex)
            {
                debugTxt.Text = ex.Message;
            }
        }
        void GetUniqIndex()
        {//получаем уникальный номер заказа, так как по одному индеску может быть несколько компонентов, то в БД он не уникальный
            try
            {
                string sql = "SELECT MAX(prodnumber) FROM orders";
                MySqlCommand command = new MySqlCommand(sql, DBConnect.Conn);
                string number = command.ExecuteScalar().ToString();


                if (number == "")
                {
                    prodNumberTxt.Text = "1";
                    currentProdIndex = Convert.ToInt32(prodNumberTxt.Text);
                }
                else
                {
                    currentProdIndex = Convert.ToInt32(number);
                    currentProdIndex += 1;
                    prodNumberTxt.Text = currentProdIndex.ToString();
                }
            }
            catch (MySqlException ex)
            {
                debugTxt.Text = ex.Message;
            }

        }
        void InsertOrderList()
        {
            try
            {
                foreach (UpdatedStr st in continedCommands)
                {
                    string sql = "INSERT INTO orders(prodnumber, quantity, date, users_idusers, storage_id, products_id, customers_id) VALUES ('" + currentProdIndex + "','"+ st.Rezerved+ "','"+ dateForm.Text+ "','"+ ActiveUser.CurrentUser + "','"+st.Id+"','"+ prodNameBox.SelectedValue.ToString()+ "','"+ customerTxt.SelectedValue.ToString() + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect.Conn);
                    cmd.ExecuteNonQuery();
                }
                GetUniqIndex();

            }
            catch (MySqlException ex)
            {
                debugTxt.Text = ex.Message;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            customerView cV = new customerView();
            cV.ShowDialog();
        }
    }
}
