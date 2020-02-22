namespace StorageManager
{
    partial class ItemManager
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.catListSel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.debugTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadBtn.Location = new System.Drawing.Point(106, 14);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Загрузить";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // catListSel
            // 
            this.catListSel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catListSel.FormattingEnabled = true;
            this.catListSel.Location = new System.Drawing.Point(92, 78);
            this.catListSel.Name = "catListSel";
            this.catListSel.Size = new System.Drawing.Size(104, 21);
            this.catListSel.TabIndex = 1;
            this.catListSel.SelectedIndexChanged += new System.EventHandler(this.catListSel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(92, 136);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(104, 20);
            this.nameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.Location = new System.Drawing.Point(106, 192);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Обновить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertBtn.Location = new System.Drawing.Point(106, 236);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 6;
            this.insertBtn.Text = "Добавить";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Visible = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // debugTxt
            // 
            this.debugTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugTxt.Location = new System.Drawing.Point(0, 296);
            this.debugTxt.Name = "debugTxt";
            this.debugTxt.Size = new System.Drawing.Size(282, 13);
            this.debugTxt.TabIndex = 7;
            this.debugTxt.Text = "Нажмите кнопку";
            this.debugTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 309);
            this.Controls.Add(this.debugTxt);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catListSel);
            this.Controls.Add(this.loadBtn);
            this.Name = "ItemManager";
            this.Text = "Управление категориями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ComboBox catListSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label debugTxt;
    }
}