namespace MyShop
{
    partial class UserI
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
            this.CartView = new System.Windows.Forms.DataGridView();
            this.AddToCartButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteFromCartButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PlusCButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.MinusCButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CountCBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.PlusButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.MinusButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OrderButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.OrderSumLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SelectTypeBox = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.UpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.RangeButton1 = new System.Windows.Forms.Button();
            this.RangeButton2 = new System.Windows.Forms.Button();
            this.RangeButton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsView
            // 
            this.ProductsView.AllowUserToAddRows = false;
            this.ProductsView.AllowUserToDeleteRows = false;
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Location = new System.Drawing.Point(12, 78);
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.ReadOnly = true;
            this.ProductsView.Size = new System.Drawing.Size(844, 191);
            this.ProductsView.TabIndex = 0;
            // 
            // CartView
            // 
            this.CartView.AllowUserToAddRows = false;
            this.CartView.AllowUserToDeleteRows = false;
            this.CartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartView.Location = new System.Drawing.Point(12, 387);
            this.CartView.Name = "CartView";
            this.CartView.ReadOnly = true;
            this.CartView.Size = new System.Drawing.Size(692, 210);
            this.CartView.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Depth = 0;
            this.AddToCartButton.Location = new System.Drawing.Point(725, 289);
            this.AddToCartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Primary = true;
            this.AddToCartButton.Size = new System.Drawing.Size(131, 36);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Добавить товар";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // DeleteFromCartButton
            // 
            this.DeleteFromCartButton.Depth = 0;
            this.DeleteFromCartButton.Location = new System.Drawing.Point(538, 633);
            this.DeleteFromCartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteFromCartButton.Name = "DeleteFromCartButton";
            this.DeleteFromCartButton.Primary = true;
            this.DeleteFromCartButton.Size = new System.Drawing.Size(166, 36);
            this.DeleteFromCartButton.TabIndex = 3;
            this.DeleteFromCartButton.Text = "Удалить товар";
            this.DeleteFromCartButton.UseVisualStyleBackColor = true;
            this.DeleteFromCartButton.Click += new System.EventHandler(this.DeleteFromCartButton_Click);
            // 
            // PlusCButton
            // 
            this.PlusCButton.AutoSize = true;
            this.PlusCButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlusCButton.Depth = 0;
            this.PlusCButton.Location = new System.Drawing.Point(511, 633);
            this.PlusCButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PlusCButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlusCButton.Name = "PlusCButton";
            this.PlusCButton.Primary = false;
            this.PlusCButton.Size = new System.Drawing.Size(20, 36);
            this.PlusCButton.TabIndex = 4;
            this.PlusCButton.Text = "+";
            this.PlusCButton.UseVisualStyleBackColor = true;
            this.PlusCButton.Click += new System.EventHandler(this.PlusCButton_Click);
            // 
            // MinusCButton
            // 
            this.MinusCButton.AutoSize = true;
            this.MinusCButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinusCButton.Depth = 0;
            this.MinusCButton.Location = new System.Drawing.Point(365, 633);
            this.MinusCButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinusCButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinusCButton.Name = "MinusCButton";
            this.MinusCButton.Primary = false;
            this.MinusCButton.Size = new System.Drawing.Size(16, 36);
            this.MinusCButton.TabIndex = 5;
            this.MinusCButton.Text = "-";
            this.MinusCButton.UseVisualStyleBackColor = true;
            this.MinusCButton.Click += new System.EventHandler(this.MinusCButton_Click);
            // 
            // CountCBox
            // 
            this.CountCBox.Location = new System.Drawing.Point(388, 642);
            this.CountCBox.Name = "CountCBox";
            this.CountCBox.Size = new System.Drawing.Size(116, 20);
            this.CountCBox.TabIndex = 6;
            this.CountCBox.Text = "1";
            this.CountCBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(561, 298);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(116, 20);
            this.CountBox.TabIndex = 7;
            this.CountBox.Text = "1";
            this.CountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlusButton
            // 
            this.PlusButton.AutoSize = true;
            this.PlusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlusButton.Depth = 0;
            this.PlusButton.Location = new System.Drawing.Point(684, 289);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PlusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Primary = false;
            this.PlusButton.Size = new System.Drawing.Size(20, 36);
            this.PlusButton.TabIndex = 8;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.AutoSize = true;
            this.MinusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinusButton.Depth = 0;
            this.MinusButton.Location = new System.Drawing.Point(538, 289);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Primary = false;
            this.MinusButton.Size = new System.Drawing.Size(16, 36);
            this.MinusButton.TabIndex = 9;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.Location = new System.Drawing.Point(795, 633);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Primary = false;
            this.ExitButton.Size = new System.Drawing.Size(60, 36);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Depth = 0;
            this.OrderButton.Location = new System.Drawing.Point(710, 484);
            this.OrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Primary = true;
            this.OrderButton.Size = new System.Drawing.Size(146, 37);
            this.OrderButton.TabIndex = 11;
            this.OrderButton.Text = "Оформить заказ";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 641);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(168, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Сумма вашего заказа:";
            // 
            // OrderSumLabel
            // 
            this.OrderSumLabel.AutoSize = true;
            this.OrderSumLabel.Depth = 0;
            this.OrderSumLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.OrderSumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OrderSumLabel.Location = new System.Drawing.Point(186, 641);
            this.OrderSumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrderSumLabel.Name = "OrderSumLabel";
            this.OrderSumLabel.Size = new System.Drawing.Size(0, 19);
            this.OrderSumLabel.TabIndex = 13;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(280, 641);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "рублей";
            // 
            // SelectTypeBox
            // 
            this.SelectTypeBox.FormattingEnabled = true;
            this.SelectTypeBox.Items.AddRange(new object[] {
            "Выберите тип",
            "Процессор",
            "Видеокарта",
            "ОЗУ",
            "Блок питания",
            "Жесткий диск",
            "Материнская плата"});
            this.SelectTypeBox.Location = new System.Drawing.Point(16, 304);
            this.SelectTypeBox.Name = "SelectTypeBox";
            this.SelectTypeBox.Size = new System.Drawing.Size(121, 21);
            this.SelectTypeBox.TabIndex = 15;
            this.SelectTypeBox.SelectedIndexChanged += new System.EventHandler(this.SelectTypeBox_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 277);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Тип товара";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Depth = 0;
            this.UpdateButton.Location = new System.Drawing.Point(570, 347);
            this.UpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Primary = true;
            this.UpdateButton.Size = new System.Drawing.Size(107, 34);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Сбросить фильтры";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(271, 277);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(110, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Диапазон цен";
            // 
            // RangeButton1
            // 
            this.RangeButton1.Location = new System.Drawing.Point(190, 319);
            this.RangeButton1.Name = "RangeButton1";
            this.RangeButton1.Size = new System.Drawing.Size(75, 23);
            this.RangeButton1.TabIndex = 20;
            this.RangeButton1.Text = "<10000";
            this.RangeButton1.UseVisualStyleBackColor = true;
            this.RangeButton1.Click += new System.EventHandler(this.RangeButton1_Click);
            // 
            // RangeButton2
            // 
            this.RangeButton2.Location = new System.Drawing.Point(284, 319);
            this.RangeButton2.Name = "RangeButton2";
            this.RangeButton2.Size = new System.Drawing.Size(75, 23);
            this.RangeButton2.TabIndex = 21;
            this.RangeButton2.Text = "10000-50000";
            this.RangeButton2.UseVisualStyleBackColor = true;
            this.RangeButton2.Click += new System.EventHandler(this.RangeButton2_Click);
            // 
            // RangeButton3
            // 
            this.RangeButton3.Location = new System.Drawing.Point(378, 318);
            this.RangeButton3.Name = "RangeButton3";
            this.RangeButton3.Size = new System.Drawing.Size(75, 23);
            this.RangeButton3.TabIndex = 22;
            this.RangeButton3.Text = ">50000";
            this.RangeButton3.UseVisualStyleBackColor = true;
            this.RangeButton3.Click += new System.EventHandler(this.RangeButton3_Click);
            // 
            // UserI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 684);
            this.Controls.Add(this.RangeButton3);
            this.Controls.Add(this.RangeButton2);
            this.Controls.Add(this.RangeButton1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.SelectTypeBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.OrderSumLabel);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.CountCBox);
            this.Controls.Add(this.MinusCButton);
            this.Controls.Add(this.PlusCButton);
            this.Controls.Add(this.DeleteFromCartButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.CartView);
            this.Controls.Add(this.ProductsView);
            this.Name = "UserI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.Activated += new System.EventHandler(this.UserI_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserI_FormClosed);
            this.Load += new System.EventHandler(this.UserI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsView;
        private System.Windows.Forms.DataGridView CartView;
        private MaterialSkin.Controls.MaterialRaisedButton AddToCartButton;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteFromCartButton;
        private MaterialSkin.Controls.MaterialFlatButton PlusCButton;
        private MaterialSkin.Controls.MaterialFlatButton MinusCButton;
        private System.Windows.Forms.TextBox CountCBox;
        private System.Windows.Forms.TextBox CountBox;
        private MaterialSkin.Controls.MaterialFlatButton PlusButton;
        private MaterialSkin.Controls.MaterialFlatButton MinusButton;
        private MaterialSkin.Controls.MaterialFlatButton ExitButton;
        private MaterialSkin.Controls.MaterialRaisedButton OrderButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel OrderSumLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox SelectTypeBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Button RangeButton1;
        private System.Windows.Forms.Button RangeButton2;
        private System.Windows.Forms.Button RangeButton3;
    }
}