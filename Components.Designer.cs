namespace StorageManager
{
    partial class Components
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
            this.debugTxt = new System.Windows.Forms.Label();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.allList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debugTxt
            // 
            this.debugTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugTxt.Location = new System.Drawing.Point(0, 205);
            this.debugTxt.Name = "debugTxt";
            this.debugTxt.Size = new System.Drawing.Size(392, 26);
            this.debugTxt.TabIndex = 0;
            this.debugTxt.Text = "label1";
            this.debugTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Location = new System.Drawing.Point(129, 39);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(121, 21);
            this.itemTypeBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Группа";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(75, 91);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(231, 20);
            this.nameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(155, 130);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // allList
            // 
            this.allList.Location = new System.Drawing.Point(155, 172);
            this.allList.Name = "allList";
            this.allList.Size = new System.Drawing.Size(75, 23);
            this.allList.TabIndex = 5;
            this.allList.Text = "Просмотр";
            this.allList.UseVisualStyleBackColor = true;
            this.allList.Click += new System.EventHandler(this.allList_Click);
            // 
            // Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 231);
            this.Controls.Add(this.allList);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemTypeBox);
            this.Controls.Add(this.debugTxt);
            this.Name = "Components";
            this.Text = "Компоненты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label debugTxt;
        private System.Windows.Forms.ComboBox itemTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button allList;
    }
}