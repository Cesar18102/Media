namespace Market
{
    partial class AuthorForm
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
            this.RemoveAuthor = new System.Windows.Forms.Button();
            this.DelID = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AuthorFathername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveAuthor);
            this.panel2.Controls.Add(this.DelID);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(459, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 162);
            this.panel2.TabIndex = 5;
            // 
            // RemoveAuthor
            // 
            this.RemoveAuthor.Location = new System.Drawing.Point(3, 47);
            this.RemoveAuthor.Name = "RemoveAuthor";
            this.RemoveAuthor.Size = new System.Drawing.Size(368, 109);
            this.RemoveAuthor.TabIndex = 6;
            this.RemoveAuthor.Text = "Удалить автора";
            this.RemoveAuthor.UseVisualStyleBackColor = true;
            this.RemoveAuthor.Click += new System.EventHandler(this.RemoveProvider_Click);
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
            this.panel1.Controls.Add(this.AuthorFathername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AuthorSurname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddAuthor);
            this.panel1.Controls.Add(this.AuthorName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 162);
            this.panel1.TabIndex = 4;
            // 
            // AuthorFathername
            // 
            this.AuthorFathername.Location = new System.Drawing.Point(121, 79);
            this.AuthorFathername.MaxLength = 15;
            this.AuthorFathername.Name = "AuthorFathername";
            this.AuthorFathername.Size = new System.Drawing.Size(329, 29);
            this.AuthorFathername.TabIndex = 3;
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
            // AuthorSurname
            // 
            this.AuthorSurname.Location = new System.Drawing.Point(121, 44);
            this.AuthorSurname.MaxLength = 100;
            this.AuthorSurname.Name = "AuthorSurname";
            this.AuthorSurname.Size = new System.Drawing.Size(329, 29);
            this.AuthorSurname.TabIndex = 2;
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
            // AddAuthor
            // 
            this.AddAuthor.Location = new System.Drawing.Point(12, 114);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(438, 42);
            this.AddAuthor.TabIndex = 4;
            this.AddAuthor.Text = "Добавить автора";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddProvider_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(121, 9);
            this.AuthorName.MaxLength = 50;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(329, 29);
            this.AuthorName.TabIndex = 1;
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
            // AuthorList
            // 
            this.AuthorList.AllowUserToAddRows = false;
            this.AuthorList.AllowUserToDeleteRows = false;
            this.AuthorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorList.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthorList.Location = new System.Drawing.Point(0, 0);
            this.AuthorList.Margin = new System.Windows.Forms.Padding(6);
            this.AuthorList.Name = "AuthorList";
            this.AuthorList.ReadOnly = true;
            this.AuthorList.RowHeadersVisible = false;
            this.AuthorList.Size = new System.Drawing.Size(842, 305);
            this.AuthorList.TabIndex = 3;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AuthorList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RemoveAuthor;
        private System.Windows.Forms.NumericUpDown DelID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AuthorFathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AuthorSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AuthorList;

    }
}