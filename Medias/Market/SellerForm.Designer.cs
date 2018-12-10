namespace Market
{
    partial class SellerForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveSeller = new System.Windows.Forms.Button();
            this.DelID = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerFathername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SellerSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSeller = new System.Windows.Forms.Button();
            this.SellerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SellerList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveSeller);
            this.panel2.Controls.Add(this.DelID);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(462, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 177);
            this.panel2.TabIndex = 8;
            // 
            // RemoveSeller
            // 
            this.RemoveSeller.Location = new System.Drawing.Point(3, 47);
            this.RemoveSeller.Name = "RemoveSeller";
            this.RemoveSeller.Size = new System.Drawing.Size(368, 109);
            this.RemoveSeller.TabIndex = 6;
            this.RemoveSeller.Text = "Уволить продавца";
            this.RemoveSeller.UseVisualStyleBackColor = true;
            this.RemoveSeller.Click += new System.EventHandler(this.RemoveSeller_Click);
            // 
            // DelID
            // 
            this.DelID.Location = new System.Drawing.Point(48, 9);
            this.DelID.Name = "DelID";
            this.DelID.Size = new System.Drawing.Size(323, 29);
            this.DelID.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.SellerFathername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SellerSurname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddSeller);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 177);
            this.panel1.TabIndex = 7;
            // 
            // SellerFathername
            // 
            this.SellerFathername.Location = new System.Drawing.Point(121, 79);
            this.SellerFathername.MaxLength = 15;
            this.SellerFathername.Name = "SellerFathername";
            this.SellerFathername.Size = new System.Drawing.Size(329, 29);
            this.SellerFathername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество: ";
            // 
            // SellerSurname
            // 
            this.SellerSurname.Location = new System.Drawing.Point(121, 44);
            this.SellerSurname.MaxLength = 100;
            this.SellerSurname.Name = "SellerSurname";
            this.SellerSurname.Size = new System.Drawing.Size(329, 29);
            this.SellerSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия: ";
            // 
            // AddSeller
            // 
            this.AddSeller.Location = new System.Drawing.Point(12, 114);
            this.AddSeller.Name = "AddSeller";
            this.AddSeller.Size = new System.Drawing.Size(438, 42);
            this.AddSeller.TabIndex = 4;
            this.AddSeller.Text = "Нанять продавца";
            this.AddSeller.UseVisualStyleBackColor = true;
            this.AddSeller.Click += new System.EventHandler(this.AddSeller_Click);
            // 
            // SellerName
            // 
            this.SellerName.Location = new System.Drawing.Point(121, 9);
            this.SellerName.MaxLength = 50;
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(329, 29);
            this.SellerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя: ";
            // 
            // SellerList
            // 
            this.SellerList.AllowUserToAddRows = false;
            this.SellerList.AllowUserToDeleteRows = false;
            this.SellerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellerList.Location = new System.Drawing.Point(0, 0);
            this.SellerList.Margin = new System.Windows.Forms.Padding(6);
            this.SellerList.Name = "SellerList";
            this.SellerList.ReadOnly = true;
            this.SellerList.RowHeadersVisible = false;
            this.SellerList.Size = new System.Drawing.Size(845, 305);
            this.SellerList.TabIndex = 6;
            this.SellerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerList_CellClick);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SellerList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RemoveSeller;
        private System.Windows.Forms.NumericUpDown DelID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SellerFathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellerSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSeller;
        private System.Windows.Forms.TextBox SellerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SellerList;
    }
}