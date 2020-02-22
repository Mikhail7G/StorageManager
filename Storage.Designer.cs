namespace StorageManager
{
    partial class Storage
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.debugTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateForm = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.docBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.storagePos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemSelector = new System.Windows.Forms.ComboBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 45);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(167, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.Visible = false;
            // 
            // debugTxt
            // 
            this.debugTxt.AutoEllipsis = true;
            this.debugTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugTxt.Location = new System.Drawing.Point(0, 167);
            this.debugTxt.Name = "debugTxt";
            this.debugTxt.Size = new System.Drawing.Size(562, 35);
            this.debugTxt.TabIndex = 1;
            this.debugTxt.Text = "Ошибка!";
            this.debugTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название компонента";
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Location = new System.Drawing.Point(222, 45);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(121, 21);
            this.itemTypeBox.TabIndex = 3;
            this.itemTypeBox.SelectedIndexChanged += new System.EventHandler(this.itemTypeBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип компонента";
            // 
            // quantBox
            // 
            this.quantBox.Location = new System.Drawing.Point(393, 45);
            this.quantBox.Name = "quantBox";
            this.quantBox.Size = new System.Drawing.Size(100, 20);
            this.quantBox.TabIndex = 5;
            this.quantBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // dateForm
            // 
            this.dateForm.CustomFormat = "yyyy.MM.dd";
            this.dateForm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateForm.Location = new System.Drawing.Point(28, 100);
            this.dateForm.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateForm.Name = "dateForm";
            this.dateForm.Size = new System.Drawing.Size(135, 20);
            this.dateForm.TabIndex = 6;
            this.dateForm.Value = new System.DateTime(2020, 2, 21, 0, 0, 0, 0);
            this.dateForm.ValueChanged += new System.EventHandler(this.dateForm_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата поставки";
            // 
            // docBox
            // 
            this.docBox.Location = new System.Drawing.Point(392, 88);
            this.docBox.Name = "docBox";
            this.docBox.Size = new System.Drawing.Size(100, 20);
            this.docBox.TabIndex = 7;
            this.docBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "№ накладной";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(242, 102);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.ClearText);
            // 
            // storagePos
            // 
            this.storagePos.Location = new System.Drawing.Point(392, 129);
            this.storagePos.Name = "storagePos";
            this.storagePos.Size = new System.Drawing.Size(100, 20);
            this.storagePos.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "№ склада";
            // 
            // itemSelector
            // 
            this.itemSelector.FormattingEnabled = true;
            this.itemSelector.Location = new System.Drawing.Point(12, 44);
            this.itemSelector.Name = "itemSelector";
            this.itemSelector.Size = new System.Drawing.Size(167, 21);
            this.itemSelector.TabIndex = 3;
            this.itemSelector.SelectedIndexChanged += new System.EventHandler(this.itemSelector_SelectedIndexChanged);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(242, 131);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 9;
            this.viewBtn.Text = "Просмотр";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Visible = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 202);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.storagePos);
            this.Controls.Add(this.docBox);
            this.Controls.Add(this.dateForm);
            this.Controls.Add(this.quantBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemSelector);
            this.Controls.Add(this.itemTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debugTxt);
            this.Controls.Add(this.nameBox);
            this.Name = "Storage";
            this.Text = "Склад";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label debugTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox docBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox storagePos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox itemSelector;
        private System.Windows.Forms.Button viewBtn;
    }
}