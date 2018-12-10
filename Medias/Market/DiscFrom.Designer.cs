namespace Market
{
    partial class DiscFrom
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
            this.DiscList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiscGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscAuthor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddDisc = new System.Windows.Forms.Button();
            this.DiscPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DiscName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveDisc = new System.Windows.Forms.Button();
            this.DelId = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.NewPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.EditPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DiscList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscPrice)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscList
            // 
            this.DiscList.AllowUserToAddRows = false;
            this.DiscList.AllowUserToDeleteRows = false;
            this.DiscList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiscList.Location = new System.Drawing.Point(0, 0);
            this.DiscList.Margin = new System.Windows.Forms.Padding(6);
            this.DiscList.Name = "DiscList";
            this.DiscList.ReadOnly = true;
            this.DiscList.RowHeadersVisible = false;
            this.DiscList.Size = new System.Drawing.Size(842, 305);
            this.DiscList.TabIndex = 0;
            this.DiscList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiscList_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DiscGenre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DiscAuthor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddDisc);
            this.panel1.Controls.Add(this.DiscPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DiscName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 241);
            this.panel1.TabIndex = 1;
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(212, 203);
            this.SearchName.MaxLength = 100;
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(238, 29);
            this.SearchName.TabIndex = 11;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поиск по названию: ";
            // 
            // DiscGenre
            // 
            this.DiscGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscGenre.FormattingEnabled = true;
            this.DiscGenre.Location = new System.Drawing.Point(121, 82);
            this.DiscGenre.Name = "DiscGenre";
            this.DiscGenre.Size = new System.Drawing.Size(329, 32);
            this.DiscGenre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Жанр: ";
            // 
            // DiscAuthor
            // 
            this.DiscAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscAuthor.FormattingEnabled = true;
            this.DiscAuthor.Location = new System.Drawing.Point(121, 44);
            this.DiscAuthor.Name = "DiscAuthor";
            this.DiscAuthor.Size = new System.Drawing.Size(329, 32);
            this.DiscAuthor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Автор: ";
            // 
            // AddDisc
            // 
            this.AddDisc.Location = new System.Drawing.Point(12, 155);
            this.AddDisc.Name = "AddDisc";
            this.AddDisc.Size = new System.Drawing.Size(438, 42);
            this.AddDisc.TabIndex = 5;
            this.AddDisc.Text = "Добавить диск";
            this.AddDisc.UseVisualStyleBackColor = true;
            this.AddDisc.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DiscPrice
            // 
            this.DiscPrice.DecimalPlaces = 2;
            this.DiscPrice.Location = new System.Drawing.Point(121, 120);
            this.DiscPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.DiscPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DiscPrice.Name = "DiscPrice";
            this.DiscPrice.Size = new System.Drawing.Size(329, 29);
            this.DiscPrice.TabIndex = 4;
            this.DiscPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена: ";
            // 
            // DiscName
            // 
            this.DiscName.Location = new System.Drawing.Point(121, 9);
            this.DiscName.MaxLength = 100;
            this.DiscName.Name = "DiscName";
            this.DiscName.Size = new System.Drawing.Size(329, 29);
            this.DiscName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EditPrice);
            this.panel2.Controls.Add(this.NewPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RemoveDisc);
            this.panel2.Controls.Add(this.DelId);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(459, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 241);
            this.panel2.TabIndex = 2;
            // 
            // RemoveDisc
            // 
            this.RemoveDisc.Location = new System.Drawing.Point(3, 47);
            this.RemoveDisc.Name = "RemoveDisc";
            this.RemoveDisc.Size = new System.Drawing.Size(377, 65);
            this.RemoveDisc.TabIndex = 7;
            this.RemoveDisc.Text = "Удалить диск";
            this.RemoveDisc.UseVisualStyleBackColor = true;
            this.RemoveDisc.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // DelId
            // 
            this.DelId.Location = new System.Drawing.Point(48, 9);
            this.DelId.Name = "DelId";
            this.DelId.Size = new System.Drawing.Size(323, 29);
            this.DelId.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(5, 11);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(37, 24);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID: ";
            // 
            // NewPrice
            // 
            this.NewPrice.DecimalPlaces = 2;
            this.NewPrice.Location = new System.Drawing.Point(145, 123);
            this.NewPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NewPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.Size = new System.Drawing.Size(226, 29);
            this.NewPrice.TabIndex = 12;
            this.NewPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Новая цена: ";
            // 
            // EditPrice
            // 
            this.EditPrice.Location = new System.Drawing.Point(3, 167);
            this.EditPrice.Name = "EditPrice";
            this.EditPrice.Size = new System.Drawing.Size(377, 65);
            this.EditPrice.TabIndex = 14;
            this.EditPrice.Text = "Редактировать цену";
            this.EditPrice.UseVisualStyleBackColor = true;
            this.EditPrice.Click += new System.EventHandler(this.EditPrice_Click);
            // 
            // DiscFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiscList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DiscFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.DiscFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiscList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscPrice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DiscList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddDisc;
        private System.Windows.Forms.NumericUpDown DiscPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DiscName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveDisc;
        private System.Windows.Forms.NumericUpDown DelId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox DiscAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DiscGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditPrice;
        private System.Windows.Forms.NumericUpDown NewPrice;
        private System.Windows.Forms.Label label6;
    }
}