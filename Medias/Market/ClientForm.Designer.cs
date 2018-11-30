namespace Market
{
    partial class ClientForm
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
            this.FireWorker = new System.Windows.Forms.Button();
            this.DelID = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientFathername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.ClientSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FireWorker);
            this.panel2.Controls.Add(this.DelID);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(460, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 236);
            this.panel2.TabIndex = 5;
            // 
            // FireWorker
            // 
            this.FireWorker.Location = new System.Drawing.Point(3, 44);
            this.FireWorker.Name = "FireWorker";
            this.FireWorker.Size = new System.Drawing.Size(368, 182);
            this.FireWorker.TabIndex = 10;
            this.FireWorker.Text = "Удалить клиента";
            this.FireWorker.UseVisualStyleBackColor = true;
            this.FireWorker.Click += new System.EventHandler(this.FireWorker_Click);
            // 
            // DelID
            // 
            this.DelID.Location = new System.Drawing.Point(48, 9);
            this.DelID.Name = "DelID";
            this.DelID.Size = new System.Drawing.Size(323, 29);
            this.DelID.TabIndex = 9;
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
            this.panel1.Controls.Add(this.ClientPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ClientMail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ClientFathername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ClientName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddClient);
            this.panel1.Controls.Add(this.ClientSurname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 236);
            this.panel1.TabIndex = 4;
            // 
            // ClientPhone
            // 
            this.ClientPhone.Location = new System.Drawing.Point(121, 149);
            this.ClientPhone.MaxLength = 15;
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(329, 29);
            this.ClientPhone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Телефон: ";
            // 
            // ClientMail
            // 
            this.ClientMail.Location = new System.Drawing.Point(121, 114);
            this.ClientMail.MaxLength = 100;
            this.ClientMail.Name = "ClientMail";
            this.ClientMail.Size = new System.Drawing.Size(329, 29);
            this.ClientMail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email: ";
            // 
            // ClientFathername
            // 
            this.ClientFathername.Location = new System.Drawing.Point(121, 79);
            this.ClientFathername.MaxLength = 20;
            this.ClientFathername.Name = "ClientFathername";
            this.ClientFathername.Size = new System.Drawing.Size(329, 29);
            this.ClientFathername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество: ";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(121, 44);
            this.ClientName.MaxLength = 20;
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(329, 29);
            this.ClientName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя: ";
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(11, 184);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(438, 42);
            this.AddClient.TabIndex = 8;
            this.AddClient.Text = "Добавить клиента";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.HireWorker_Click);
            // 
            // ClientSurname
            // 
            this.ClientSurname.Location = new System.Drawing.Point(121, 9);
            this.ClientSurname.MaxLength = 30;
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.Size = new System.Drawing.Size(329, 29);
            this.ClientSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия: ";
            // 
            // ClientList
            // 
            this.ClientList.AllowUserToAddRows = false;
            this.ClientList.AllowUserToDeleteRows = false;
            this.ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientList.Location = new System.Drawing.Point(0, 0);
            this.ClientList.Margin = new System.Windows.Forms.Padding(6);
            this.ClientList.Name = "ClientList";
            this.ClientList.ReadOnly = true;
            this.ClientList.RowHeadersVisible = false;
            this.ClientList.Size = new System.Drawing.Size(843, 305);
            this.ClientList.TabIndex = 3;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FireWorker;
        private System.Windows.Forms.NumericUpDown DelID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox ClientSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientList;
        private System.Windows.Forms.TextBox ClientFathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClientMail;
        private System.Windows.Forms.Label label5;

    }
}