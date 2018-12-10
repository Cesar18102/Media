namespace Market
{
    partial class Purchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientCB = new System.Windows.Forms.CheckBox();
            this.ClientVAL = new System.Windows.Forms.ComboBox();
            this.Seller = new System.Windows.Forms.ComboBox();
            this.Client = new System.Windows.Forms.ComboBox();
            this.SellerCB = new System.Windows.Forms.CheckBox();
            this.SellerVAL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Disc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDeal = new System.Windows.Forms.Button();
            this.DealList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClientCB);
            this.panel1.Controls.Add(this.ClientVAL);
            this.panel1.Controls.Add(this.Seller);
            this.panel1.Controls.Add(this.Client);
            this.panel1.Controls.Add(this.SellerCB);
            this.panel1.Controls.Add(this.SellerVAL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Disc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddDeal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 269);
            this.panel1.TabIndex = 6;
            // 
            // ClientCB
            // 
            this.ClientCB.AutoSize = true;
            this.ClientCB.Location = new System.Drawing.Point(411, 216);
            this.ClientCB.Name = "ClientCB";
            this.ClientCB.Size = new System.Drawing.Size(104, 28);
            this.ClientCB.TabIndex = 24;
            this.ClientCB.Text = "Клиент: ";
            this.ClientCB.UseVisualStyleBackColor = true;
            this.ClientCB.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // ClientVAL
            // 
            this.ClientVAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientVAL.FormattingEnabled = true;
            this.ClientVAL.Location = new System.Drawing.Point(521, 214);
            this.ClientVAL.Name = "ClientVAL";
            this.ClientVAL.Size = new System.Drawing.Size(170, 32);
            this.ClientVAL.TabIndex = 23;
            this.ClientVAL.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // Seller
            // 
            this.Seller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Seller.FormattingEnabled = true;
            this.Seller.Location = new System.Drawing.Point(192, 78);
            this.Seller.Name = "Seller";
            this.Seller.Size = new System.Drawing.Size(499, 32);
            this.Seller.TabIndex = 22;
            // 
            // Client
            // 
            this.Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Client.FormattingEnabled = true;
            this.Client.Location = new System.Drawing.Point(192, 40);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(499, 32);
            this.Client.TabIndex = 21;
            // 
            // SellerCB
            // 
            this.SellerCB.AutoSize = true;
            this.SellerCB.Location = new System.Drawing.Point(12, 216);
            this.SellerCB.Name = "SellerCB";
            this.SellerCB.Size = new System.Drawing.Size(129, 28);
            this.SellerCB.TabIndex = 19;
            this.SellerCB.Text = "Продавец: ";
            this.SellerCB.UseVisualStyleBackColor = true;
            this.SellerCB.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // SellerVAL
            // 
            this.SellerVAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SellerVAL.FormattingEnabled = true;
            this.SellerVAL.Location = new System.Drawing.Point(147, 214);
            this.SellerVAL.Name = "SellerVAL";
            this.SellerVAL.Size = new System.Drawing.Size(170, 32);
            this.SellerVAL.TabIndex = 14;
            this.SellerVAL.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фильтры: ";
            // 
            // Disc
            // 
            this.Disc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Disc.FormattingEnabled = true;
            this.Disc.Location = new System.Drawing.Point(192, 3);
            this.Disc.Name = "Disc";
            this.Disc.Size = new System.Drawing.Size(499, 32);
            this.Disc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Продавец: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Клиент: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Диск: ";
            // 
            // AddDeal
            // 
            this.AddDeal.Location = new System.Drawing.Point(12, 116);
            this.AddDeal.Name = "AddDeal";
            this.AddDeal.Size = new System.Drawing.Size(680, 42);
            this.AddDeal.TabIndex = 4;
            this.AddDeal.Text = "Добавить покупку";
            this.AddDeal.UseVisualStyleBackColor = true;
            this.AddDeal.Click += new System.EventHandler(this.AddDeal_Click);
            // 
            // DealList
            // 
            this.DealList.AllowUserToAddRows = false;
            this.DealList.AllowUserToDeleteRows = false;
            this.DealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DealList.Location = new System.Drawing.Point(0, 0);
            this.DealList.Margin = new System.Windows.Forms.Padding(6);
            this.DealList.Name = "DealList";
            this.DealList.ReadOnly = true;
            this.DealList.RowHeadersVisible = false;
            this.DealList.Size = new System.Drawing.Size(711, 305);
            this.DealList.TabIndex = 5;
            this.DealList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DealList_CellClick);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DealList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealForm";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Disc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDeal;
        private System.Windows.Forms.DataGridView DealList;
        private System.Windows.Forms.ComboBox Seller;
        private System.Windows.Forms.ComboBox Client;
        private System.Windows.Forms.CheckBox ClientCB;
        private System.Windows.Forms.ComboBox ClientVAL;
        private System.Windows.Forms.CheckBox SellerCB;
        private System.Windows.Forms.ComboBox SellerVAL;
        private System.Windows.Forms.Label label2;
    }
}