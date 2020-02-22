using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CurrentUserAccess();
            this.MinimumSize = new Size(229, 404);
            this.MaximumSize = new Size(267, 425);
        }

        private void CurrentUserAccess()//различные кнопки для каждого пользователя
        {
            switch(ActiveUser.UserPrevilegies)
            {
                case 1://кнопки админа
                    userControlBtn.Visible = true;
                    itemCat.Visible = true;
                    storage.Visible = true;
                    prodBtn.Visible = true;
                    componentBtn.Visible = true;
                    customerBtn.Visible = true;
                    prodlistBtn.Visible = true;
                    break;

                case 2://кнопки рабочего
                    storage.Visible = true;
                    storage.Location = userControlBtn.Location;
                    break;
            }

        }

        private void userControlBtn_Click(object sender, EventArgs e)
        {
            UserControl UserForm = new UserControl();
            UserForm.ShowDialog();   
        }

        private void itemCat_Click(object sender, EventArgs e)
        {
            //ItemManager DBitems = new ItemManager();
            //DBitems.ShowDialog();
            Itemmanager2 DBitems = new Itemmanager2();
            DBitems.ShowDialog();
        }

        private void storage_Click(object sender, EventArgs e)
        {
            Storage storageForm = new Storage();
            storageForm.ShowDialog();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Product prodForm = new Product();
            prodForm.ShowDialog();
                
        }

        private void componentBtn_Click(object sender, EventArgs e)
        {
            Components comp = new Components();
            comp.ShowDialog();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            customers c = new customers();
            c.ShowDialog();
        }

        private void prodlistBtn_Click(object sender, EventArgs e)
        {
            prodList pList = new prodList();
            pList.ShowDialog();
        }
    }
}
