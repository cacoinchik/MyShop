namespace MyShop
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToUIButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ToAIButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // ToUIButton
            // 
            this.ToUIButton.Depth = 0;
            this.ToUIButton.Location = new System.Drawing.Point(106, 186);
            this.ToUIButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToUIButton.Name = "ToUIButton";
            this.ToUIButton.Primary = true;
            this.ToUIButton.Size = new System.Drawing.Size(204, 52);
            this.ToUIButton.TabIndex = 0;
            this.ToUIButton.Text = "Покупатель";
            this.ToUIButton.UseVisualStyleBackColor = true;
            this.ToUIButton.Click += new System.EventHandler(this.ToUIButton_Click);
            // 
            // ToAIButton
            // 
            this.ToAIButton.Depth = 0;
            this.ToAIButton.Location = new System.Drawing.Point(106, 310);
            this.ToAIButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToAIButton.Name = "ToAIButton";
            this.ToAIButton.Primary = true;
            this.ToAIButton.Size = new System.Drawing.Size(204, 52);
            this.ToAIButton.TabIndex = 1;
            this.ToAIButton.Text = "Администратор";
            this.ToAIButton.UseVisualStyleBackColor = true;
            this.ToAIButton.Click += new System.EventHandler(this.ToAIButton_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(316, 484);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(61, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Выход";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 535);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.ToAIButton);
            this.Controls.Add(this.ToUIButton);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton ToUIButton;
        private MaterialSkin.Controls.MaterialRaisedButton ToAIButton;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

