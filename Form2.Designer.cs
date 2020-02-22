namespace StorageManager
{
    partial class Form2
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
            this.userControlBtn = new System.Windows.Forms.Button();
            this.itemCat = new System.Windows.Forms.Button();
            this.storage = new System.Windows.Forms.Button();
            this.prodBtn = new System.Windows.Forms.Button();
            this.componentBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.prodlistBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControlBtn
            // 
            this.userControlBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userControlBtn.Location = new System.Drawing.Point(75, 23);
            this.userControlBtn.Name = "userControlBtn";
            this.userControlBtn.Size = new System.Drawing.Size(94, 32);
            this.userControlBtn.TabIndex = 0;
            this.userControlBtn.Text = "Пользователи";
            this.userControlBtn.UseVisualStyleBackColor = true;
            this.userControlBtn.Visible = false;
            this.userControlBtn.Click += new System.EventHandler(this.userControlBtn_Click);
            // 
            // itemCat
            // 
            this.itemCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemCat.Location = new System.Drawing.Point(75, 72);
            this.itemCat.Name = "itemCat";
            this.itemCat.Size = new System.Drawing.Size(94, 32);
            this.itemCat.TabIndex = 1;
            this.itemCat.Text = "Категории";
            this.itemCat.UseVisualStyleBackColor = true;
            this.itemCat.Visible = false;
            this.itemCat.Click += new System.EventHandler(this.itemCat_Click);
            // 
            // storage
            // 
            this.storage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.storage.Location = new System.Drawing.Point(75, 210);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(94, 32);
            this.storage.TabIndex = 2;
            this.storage.Text = "Склад";
            this.storage.UseVisualStyleBackColor = true;
            this.storage.Visible = false;
            this.storage.Click += new System.EventHandler(this.storage_Click);
            // 
            // prodBtn
            // 
            this.prodBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodBtn.Location = new System.Drawing.Point(75, 258);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Size = new System.Drawing.Size(94, 32);
            this.prodBtn.TabIndex = 2;
            this.prodBtn.Text = "Сборка";
            this.prodBtn.UseVisualStyleBackColor = true;
            this.prodBtn.Visible = false;
            this.prodBtn.Click += new System.EventHandler(this.prodBtn_Click);
            // 
            // componentBtn
            // 
            this.componentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.componentBtn.Location = new System.Drawing.Point(75, 117);
            this.componentBtn.Name = "componentBtn";
            this.componentBtn.Size = new System.Drawing.Size(94, 32);
            this.componentBtn.TabIndex = 3;
            this.componentBtn.Text = "Компоненты";
            this.componentBtn.UseVisualStyleBackColor = true;
            this.componentBtn.Visible = false;
            this.componentBtn.Click += new System.EventHandler(this.componentBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerBtn.Location = new System.Drawing.Point(75, 305);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(94, 32);
            this.customerBtn.TabIndex = 4;
            this.customerBtn.Text = "Заказчики";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Visible = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // prodlistBtn
            // 
            this.prodlistBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodlistBtn.Location = new System.Drawing.Point(75, 156);
            this.prodlistBtn.Name = "prodlistBtn";
            this.prodlistBtn.Size = new System.Drawing.Size(94, 43);
            this.prodlistBtn.TabIndex = 5;
            this.prodlistBtn.Text = "Готовая продукция";
            this.prodlistBtn.UseVisualStyleBackColor = true;
            this.prodlistBtn.Visible = false;
            this.prodlistBtn.Click += new System.EventHandler(this.prodlistBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 386);
            this.Controls.Add(this.prodlistBtn);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.componentBtn);
            this.Controls.Add(this.prodBtn);
            this.Controls.Add(this.storage);
            this.Controls.Add(this.itemCat);
            this.Controls.Add(this.userControlBtn);
            this.Name = "Form2";
            this.Text = "Меню действий";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userControlBtn;
        private System.Windows.Forms.Button itemCat;
        private System.Windows.Forms.Button storage;
        private System.Windows.Forms.Button prodBtn;
        private System.Windows.Forms.Button componentBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button prodlistBtn;
    }
}