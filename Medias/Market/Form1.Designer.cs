namespace Market
{
    partial class Form1
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
            this.Client = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Button();
            this.Seller = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.Button();
            this.Deal = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.Button();
            this.DealReport = new System.Windows.Forms.Button();
            this.DiscReport = new System.Windows.Forms.Button();
            this.GenreStats = new System.Windows.Forms.Button();
            this.Parse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(12, 12);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(367, 46);
            this.Client.TabIndex = 0;
            this.Client.Text = "Добавить/Удалить клиента";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Worker_Click);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(12, 116);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(367, 46);
            this.Author.TabIndex = 3;
            this.Author.Text = "Регистрация/Удаление автора";
            this.Author.UseVisualStyleBackColor = true;
            this.Author.Click += new System.EventHandler(this.Provider_Click);
            // 
            // Seller
            // 
            this.Seller.Location = new System.Drawing.Point(12, 168);
            this.Seller.Name = "Seller";
            this.Seller.Size = new System.Drawing.Size(367, 46);
            this.Seller.TabIndex = 4;
            this.Seller.Text = "Добавить/Удалить продавца";
            this.Seller.UseVisualStyleBackColor = true;
            this.Seller.Click += new System.EventHandler(this.Seller_Click);
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(12, 220);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(367, 46);
            this.Product.TabIndex = 6;
            this.Product.Text = "Добавить/Удалить товар";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(12, 64);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(367, 46);
            this.Genre.TabIndex = 2;
            this.Genre.Text = "Добавть/Удалить жанр";
            this.Genre.UseVisualStyleBackColor = true;
            this.Genre.Click += new System.EventHandler(this.Post_Click);
            // 
            // Deal
            // 
            this.Deal.Location = new System.Drawing.Point(12, 272);
            this.Deal.Name = "Deal";
            this.Deal.Size = new System.Drawing.Size(367, 46);
            this.Deal.TabIndex = 5;
            this.Deal.Text = "Регистрация покупки";
            this.Deal.UseVisualStyleBackColor = true;
            this.Deal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(12, 324);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(367, 46);
            this.Summary.TabIndex = 8;
            this.Summary.Text = "Итоги";
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // DealReport
            // 
            this.DealReport.Location = new System.Drawing.Point(12, 428);
            this.DealReport.Name = "DealReport";
            this.DealReport.Size = new System.Drawing.Size(367, 46);
            this.DealReport.TabIndex = 10;
            this.DealReport.Text = "Отчет по покупкам";
            this.DealReport.UseVisualStyleBackColor = true;
            this.DealReport.Click += new System.EventHandler(this.DealReport_Click);
            // 
            // DiscReport
            // 
            this.DiscReport.Location = new System.Drawing.Point(12, 376);
            this.DiscReport.Name = "DiscReport";
            this.DiscReport.Size = new System.Drawing.Size(367, 46);
            this.DiscReport.TabIndex = 9;
            this.DiscReport.Text = "Отчет по дискам";
            this.DiscReport.UseVisualStyleBackColor = true;
            this.DiscReport.Click += new System.EventHandler(this.SypplyReport_Click);
            // 
            // GenreStats
            // 
            this.GenreStats.Location = new System.Drawing.Point(12, 480);
            this.GenreStats.Name = "GenreStats";
            this.GenreStats.Size = new System.Drawing.Size(367, 46);
            this.GenreStats.TabIndex = 11;
            this.GenreStats.Text = "Статистика по жанрам";
            this.GenreStats.UseVisualStyleBackColor = true;
            this.GenreStats.Click += new System.EventHandler(this.GenreStats_Click);
            // 
            // Parse
            // 
            this.Parse.Location = new System.Drawing.Point(12, 532);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(367, 46);
            this.Parse.TabIndex = 12;
            this.Parse.Text = "Парсинг";
            this.Parse.UseVisualStyleBackColor = true;
            this.Parse.Click += new System.EventHandler(this.Parse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 585);
            this.Controls.Add(this.Parse);
            this.Controls.Add(this.GenreStats);
            this.Controls.Add(this.DealReport);
            this.Controls.Add(this.DiscReport);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.Deal);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Seller);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Client);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Button Author;
        private System.Windows.Forms.Button Seller;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Genre;
        private System.Windows.Forms.Button Deal;
        private System.Windows.Forms.Button Summary;
        private System.Windows.Forms.Button DealReport;
        private System.Windows.Forms.Button DiscReport;
        private System.Windows.Forms.Button GenreStats;
        private System.Windows.Forms.Button Parse;
    }
}

