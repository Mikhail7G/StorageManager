namespace StorageManager
{
    partial class Product
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodCombo = new System.Windows.Forms.ComboBox();
            this.CompBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.debugTxt = new System.Windows.Forms.Label();
            this.quantTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerTxt = new System.Windows.Forms.ComboBox();
            this.dateForm = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.quantLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.IntertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.prodNameBox = new System.Windows.Forms.ComboBox();
            this.prodNumberTxt = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заказчик";
            // 
            // prodCombo
            // 
            this.prodCombo.FormattingEnabled = true;
            this.prodCombo.Location = new System.Drawing.Point(409, 47);
            this.prodCombo.Name = "prodCombo";
            this.prodCombo.Size = new System.Drawing.Size(172, 21);
            this.prodCombo.TabIndex = 4;
            this.prodCombo.SelectedIndexChanged += new System.EventHandler(this.prodCombo_SelectedIndexChanged);
            // 
            // CompBox
            // 
            this.CompBox.FormattingEnabled = true;
            this.CompBox.Location = new System.Drawing.Point(299, 99);
            this.CompBox.Name = "CompBox";
            this.CompBox.Size = new System.Drawing.Size(209, 21);
            this.CompBox.TabIndex = 4;
            this.CompBox.SelectedIndexChanged += new System.EventHandler(this.CompBox0_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Компонент";
            // 
            // debugTxt
            // 
            this.debugTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugTxt.Location = new System.Drawing.Point(0, 339);
            this.debugTxt.Name = "debugTxt";
            this.debugTxt.Size = new System.Drawing.Size(673, 28);
            this.debugTxt.TabIndex = 1;
            this.debugTxt.Text = "Сформируйте заказ";
            this.debugTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantTxt
            // 
            this.quantTxt.Location = new System.Drawing.Point(549, 100);
            this.quantTxt.Name = "quantTxt";
            this.quantTxt.Size = new System.Drawing.Size(81, 20);
            this.quantTxt.TabIndex = 5;
            this.quantTxt.Text = "0";
            this.quantTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantTxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Количество";
            // 
            // customerTxt
            // 
            this.customerTxt.FormattingEnabled = true;
            this.customerTxt.Location = new System.Drawing.Point(62, 99);
            this.customerTxt.Name = "customerTxt";
            this.customerTxt.Size = new System.Drawing.Size(149, 21);
            this.customerTxt.TabIndex = 6;
            // 
            // dateForm
            // 
            this.dateForm.CustomFormat = "yyyy.MM.dd";
            this.dateForm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateForm.Location = new System.Drawing.Point(62, 163);
            this.dateForm.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateForm.Name = "dateForm";
            this.dateForm.Size = new System.Drawing.Size(149, 20);
            this.dateForm.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Дата заказа";
            // 
            // quantLbl
            // 
            this.quantLbl.AutoSize = true;
            this.quantLbl.Location = new System.Drawing.Point(430, 133);
            this.quantLbl.Name = "quantLbl";
            this.quantLbl.Size = new System.Drawing.Size(13, 13);
            this.quantLbl.TabIndex = 8;
            this.quantLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "На складе:";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(456, 160);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(111, 23);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "Зарезирвировать";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(254, 99);
            this.dataGridView1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Выбранные компоненты";
            // 
            // IntertBtn
            // 
            this.IntertBtn.Location = new System.Drawing.Point(299, 295);
            this.IntertBtn.Name = "IntertBtn";
            this.IntertBtn.Size = new System.Drawing.Size(75, 23);
            this.IntertBtn.TabIndex = 12;
            this.IntertBtn.Text = "Оформить";
            this.IntertBtn.UseVisualStyleBackColor = true;
            this.IntertBtn.Click += new System.EventHandler(this.IntertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(480, 324);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Отменить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // prodNameBox
            // 
            this.prodNameBox.FormattingEnabled = true;
            this.prodNameBox.Location = new System.Drawing.Point(62, 46);
            this.prodNameBox.Name = "prodNameBox";
            this.prodNameBox.Size = new System.Drawing.Size(149, 21);
            this.prodNameBox.TabIndex = 13;
            // 
            // prodNumberTxt
            // 
            this.prodNumberTxt.AutoSize = true;
            this.prodNumberTxt.Location = new System.Drawing.Point(0, 305);
            this.prodNumberTxt.Name = "prodNumberTxt";
            this.prodNumberTxt.Size = new System.Drawing.Size(35, 13);
            this.prodNumberTxt.TabIndex = 14;
            this.prodNumberTxt.Text = "label9";
            this.prodNumberTxt.Visible = false;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(183, 291);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 41);
            this.viewBtn.TabIndex = 15;
            this.viewBtn.Text = "Просмотр заказов";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 367);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.prodNumberTxt);
            this.Controls.Add(this.prodNameBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.IntertBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantLbl);
            this.Controls.Add(this.dateForm);
            this.Controls.Add(this.customerTxt);
            this.Controls.Add(this.quantTxt);
            this.Controls.Add(this.CompBox);
            this.Controls.Add(this.prodCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debugTxt);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Сборка продукции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Product_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox prodCombo;
        private System.Windows.Forms.ComboBox CompBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label debugTxt;
        private System.Windows.Forms.TextBox quantTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox customerTxt;
        private System.Windows.Forms.DateTimePicker dateForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label quantLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button IntertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox prodNameBox;
        private System.Windows.Forms.Label prodNumberTxt;
        private System.Windows.Forms.Button viewBtn;
    }
}