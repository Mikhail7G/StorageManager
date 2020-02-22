namespace StorageManager
{
    partial class UserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadedUserSel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userPassTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.proectBtn = new System.Windows.Forms.RadioButton();
            this.economistBtn = new System.Windows.Forms.RadioButton();
            this.storageUser = new System.Windows.Forms.RadioButton();
            this.AdminPrevBtn = new System.Windows.Forms.RadioButton();
            this.debugLbl = new System.Windows.Forms.Label();
            this.loadFromDB = new System.Windows.Forms.Button();
            this.UpdateDBBtn = new System.Windows.Forms.Button();
            this.addNewUserBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadedUserSel
            // 
            this.loadedUserSel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadedUserSel.FormattingEnabled = true;
            this.loadedUserSel.Location = new System.Drawing.Point(76, 31);
            this.loadedUserSel.Name = "loadedUserSel";
            this.loadedUserSel.Size = new System.Drawing.Size(122, 21);
            this.loadedUserSel.TabIndex = 0;
            this.loadedUserSel.SelectedIndexChanged += new System.EventHandler(this.loadedUserSel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор пользователя";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя пользователя";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTxt.Location = new System.Drawing.Point(79, 86);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(119, 20);
            this.userNameTxt.TabIndex = 3;
            // 
            // userPassTxt
            // 
            this.userPassTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPassTxt.Location = new System.Drawing.Point(76, 146);
            this.userPassTxt.Name = "userPassTxt";
            this.userPassTxt.Size = new System.Drawing.Size(119, 20);
            this.userPassTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Уровень допуска";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.proectBtn);
            this.panel1.Controls.Add(this.economistBtn);
            this.panel1.Controls.Add(this.storageUser);
            this.panel1.Controls.Add(this.AdminPrevBtn);
            this.panel1.Location = new System.Drawing.Point(73, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 117);
            this.panel1.TabIndex = 8;
            // 
            // proectBtn
            // 
            this.proectBtn.AccessibleName = "3";
            this.proectBtn.AutoSize = true;
            this.proectBtn.Location = new System.Drawing.Point(14, 60);
            this.proectBtn.Name = "proectBtn";
            this.proectBtn.Size = new System.Drawing.Size(107, 17);
            this.proectBtn.TabIndex = 3;
            this.proectBtn.TabStop = true;
            this.proectBtn.Text = "Проектировщик";
            this.proectBtn.UseVisualStyleBackColor = true;
            this.proectBtn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // economistBtn
            // 
            this.economistBtn.AccessibleName = "4";
            this.economistBtn.AutoSize = true;
            this.economistBtn.Location = new System.Drawing.Point(14, 86);
            this.economistBtn.Name = "economistBtn";
            this.economistBtn.Size = new System.Drawing.Size(76, 17);
            this.economistBtn.TabIndex = 2;
            this.economistBtn.TabStop = true;
            this.economistBtn.Text = "Бухгалтер";
            this.economistBtn.UseVisualStyleBackColor = true;
            this.economistBtn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // storageUser
            // 
            this.storageUser.AccessibleName = "2";
            this.storageUser.AutoSize = true;
            this.storageUser.Location = new System.Drawing.Point(14, 37);
            this.storageUser.Name = "storageUser";
            this.storageUser.Size = new System.Drawing.Size(106, 17);
            this.storageUser.TabIndex = 1;
            this.storageUser.TabStop = true;
            this.storageUser.Text = "Рабочий скалда";
            this.storageUser.UseVisualStyleBackColor = true;
            this.storageUser.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // AdminPrevBtn
            // 
            this.AdminPrevBtn.AccessibleName = "1";
            this.AdminPrevBtn.AutoSize = true;
            this.AdminPrevBtn.Location = new System.Drawing.Point(14, 14);
            this.AdminPrevBtn.Name = "AdminPrevBtn";
            this.AdminPrevBtn.Size = new System.Drawing.Size(104, 17);
            this.AdminPrevBtn.TabIndex = 0;
            this.AdminPrevBtn.TabStop = true;
            this.AdminPrevBtn.Text = "Администратор";
            this.AdminPrevBtn.UseVisualStyleBackColor = true;
            this.AdminPrevBtn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // debugLbl
            // 
            this.debugLbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.debugLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugLbl.Location = new System.Drawing.Point(0, 399);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(290, 13);
            this.debugLbl.TabIndex = 9;
            this.debugLbl.Text = "Выбор пользователя";
            this.debugLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadFromDB
            // 
            this.loadFromDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadFromDB.Location = new System.Drawing.Point(204, 28);
            this.loadFromDB.Name = "loadFromDB";
            this.loadFromDB.Size = new System.Drawing.Size(75, 23);
            this.loadFromDB.TabIndex = 10;
            this.loadFromDB.Text = "Загрузить";
            this.loadFromDB.UseVisualStyleBackColor = true;
            this.loadFromDB.Click += new System.EventHandler(this.loadFromDB_Click);
            // 
            // UpdateDBBtn
            // 
            this.UpdateDBBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateDBBtn.Location = new System.Drawing.Point(90, 325);
            this.UpdateDBBtn.Name = "UpdateDBBtn";
            this.UpdateDBBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateDBBtn.TabIndex = 11;
            this.UpdateDBBtn.TabStop = false;
            this.UpdateDBBtn.Text = "Обновить";
            this.UpdateDBBtn.UseVisualStyleBackColor = true;
            this.UpdateDBBtn.Visible = false;
            this.UpdateDBBtn.Click += new System.EventHandler(this.UpdateDBBtn_Click);
            // 
            // addNewUserBtn
            // 
            this.addNewUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewUserBtn.Location = new System.Drawing.Point(90, 354);
            this.addNewUserBtn.Name = "addNewUserBtn";
            this.addNewUserBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewUserBtn.TabIndex = 12;
            this.addNewUserBtn.TabStop = false;
            this.addNewUserBtn.Text = "Добавить";
            this.addNewUserBtn.UseVisualStyleBackColor = true;
            this.addNewUserBtn.Click += new System.EventHandler(this.addNewUserBtn_Click);
            // 
            // UserControl
            // 
            this.AccessibleName = "1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 412);
            this.Controls.Add(this.addNewUserBtn);
            this.Controls.Add(this.UpdateDBBtn);
            this.Controls.Add(this.loadFromDB);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userPassTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadedUserSel);
            this.Name = "UserControl";
            this.Text = "Управление пользвателями";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loadedUserSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox userPassTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton AdminPrevBtn;
        private System.Windows.Forms.RadioButton economistBtn;
        private System.Windows.Forms.RadioButton storageUser;
        private System.Windows.Forms.Label debugLbl;
        private System.Windows.Forms.Button loadFromDB;
        private System.Windows.Forms.Button UpdateDBBtn;
        private System.Windows.Forms.Button addNewUserBtn;
        private System.Windows.Forms.RadioButton proectBtn;
    }
}