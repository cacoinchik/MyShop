namespace MyShop
{
    partial class AdminI
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
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.DeleteProductButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ChangeProductButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddProductButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FirmBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.NameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FirmLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CountBox = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ChecksView = new System.Windows.Forms.DataGridView();
            this.EndOrderButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChecksView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsView
            // 
            this.ProductsView.AllowUserToAddRows = false;
            this.ProductsView.AllowUserToDeleteRows = false;
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Location = new System.Drawing.Point(12, 77);
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.ReadOnly = true;
            this.ProductsView.Size = new System.Drawing.Size(776, 188);
            this.ProductsView.TabIndex = 0;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Depth = 0;
            this.DeleteProductButton.Location = new System.Drawing.Point(212, 298);
            this.DeleteProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Primary = true;
            this.DeleteProductButton.Size = new System.Drawing.Size(135, 32);
            this.DeleteProductButton.TabIndex = 1;
            this.DeleteProductButton.Text = "Удалить товар";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ChangeProductButton
            // 
            this.ChangeProductButton.Depth = 0;
            this.ChangeProductButton.Location = new System.Drawing.Point(412, 298);
            this.ChangeProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeProductButton.Name = "ChangeProductButton";
            this.ChangeProductButton.Primary = true;
            this.ChangeProductButton.Size = new System.Drawing.Size(137, 32);
            this.ChangeProductButton.TabIndex = 2;
            this.ChangeProductButton.Text = "Изменить товар";
            this.ChangeProductButton.UseVisualStyleBackColor = true;
            this.ChangeProductButton.Click += new System.EventHandler(this.ChangeProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Depth = 0;
            this.AddProductButton.Location = new System.Drawing.Point(12, 298);
            this.AddProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Primary = true;
            this.AddProductButton.Size = new System.Drawing.Size(137, 32);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "Добавить товар";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(621, 334);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 20);
            this.NameBox.TabIndex = 4;
            // 
            // FirmBox
            // 
            this.FirmBox.Location = new System.Drawing.Point(621, 394);
            this.FirmBox.Name = "FirmBox";
            this.FirmBox.Size = new System.Drawing.Size(120, 20);
            this.FirmBox.TabIndex = 5;
            // 
            // PriceBox
            // 
            this.PriceBox.DecimalPlaces = 2;
            this.PriceBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PriceBox.Location = new System.Drawing.Point(621, 454);
            this.PriceBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(120, 20);
            this.PriceBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Depth = 0;
            this.NameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameLabel.Location = new System.Drawing.Point(651, 304);
            this.NameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 19);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Имя";
            // 
            // FirmLabel
            // 
            this.FirmLabel.AutoSize = true;
            this.FirmLabel.Depth = 0;
            this.FirmLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FirmLabel.Location = new System.Drawing.Point(651, 364);
            this.FirmLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirmLabel.Name = "FirmLabel";
            this.FirmLabel.Size = new System.Drawing.Size(57, 19);
            this.FirmLabel.TabIndex = 8;
            this.FirmLabel.Text = "Фирма";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Depth = 0;
            this.PriceLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceLabel.Location = new System.Drawing.Point(651, 424);
            this.PriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(45, 19);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Цена";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Depth = 0;
            this.CountLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CountLabel.Location = new System.Drawing.Point(633, 484);
            this.CountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(95, 19);
            this.CountLabel.TabIndex = 10;
            this.CountLabel.Text = "Количество";
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(621, 514);
            this.CountBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(120, 20);
            this.CountBox.TabIndex = 11;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(637, 544);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Описание";
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(621, 574);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(120, 20);
            this.DescBox.TabIndex = 13;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.Location = new System.Drawing.Point(727, 696);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Primary = false;
            this.ExitButton.Size = new System.Drawing.Size(60, 36);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Depth = 0;
            this.SaveButton.Location = new System.Drawing.Point(412, 364);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = true;
            this.SaveButton.Size = new System.Drawing.Size(137, 32);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 377);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(137, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Активные заказы";
            // 
            // ChecksView
            // 
            this.ChecksView.AllowUserToAddRows = false;
            this.ChecksView.AllowUserToDeleteRows = false;
            this.ChecksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChecksView.Location = new System.Drawing.Point(13, 414);
            this.ChecksView.Name = "ChecksView";
            this.ChecksView.ReadOnly = true;
            this.ChecksView.Size = new System.Drawing.Size(536, 276);
            this.ChecksView.TabIndex = 17;
            // 
            // EndOrderButton
            // 
            this.EndOrderButton.Depth = 0;
            this.EndOrderButton.Location = new System.Drawing.Point(212, 696);
            this.EndOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EndOrderButton.Name = "EndOrderButton";
            this.EndOrderButton.Primary = true;
            this.EndOrderButton.Size = new System.Drawing.Size(135, 47);
            this.EndOrderButton.TabIndex = 18;
            this.EndOrderButton.Text = "Заказ выдан";
            this.EndOrderButton.UseVisualStyleBackColor = true;
            this.EndOrderButton.Click += new System.EventHandler(this.EndOrderButton_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Тип товара",
            "Процессор",
            "Видеокарта",
            "ОЗУ",
            "Жесткий диск",
            "Материнская плата",
            "Блок питания"});
            this.TypeBox.Location = new System.Drawing.Point(621, 634);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 19;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(633, 604);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(91, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Тип товара";
            // 
            // AdminI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 747);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.EndOrderButton);
            this.Controls.Add(this.ChecksView);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.FirmLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.FirmBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ChangeProductButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ProductsView);
            this.Name = "AdminI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminI_FormClosed);
            this.Load += new System.EventHandler(this.AdminI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChecksView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsView;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteProductButton;
        private MaterialSkin.Controls.MaterialRaisedButton ChangeProductButton;
        private MaterialSkin.Controls.MaterialRaisedButton AddProductButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox FirmBox;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private MaterialSkin.Controls.MaterialLabel NameLabel;
        private MaterialSkin.Controls.MaterialLabel FirmLabel;
        private MaterialSkin.Controls.MaterialLabel PriceLabel;
        private MaterialSkin.Controls.MaterialLabel CountLabel;
        private System.Windows.Forms.NumericUpDown CountBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox DescBox;
        private MaterialSkin.Controls.MaterialFlatButton ExitButton;
        private MaterialSkin.Controls.MaterialRaisedButton SaveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView ChecksView;
        private MaterialSkin.Controls.MaterialRaisedButton EndOrderButton;
        private System.Windows.Forms.ComboBox TypeBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}