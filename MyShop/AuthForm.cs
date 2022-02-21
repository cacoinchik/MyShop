using System;
using MaterialSkin.Controls;
using MaterialSkin;
using DbLibrary;
using DbLibrary.Models;

namespace MyShop
{
    public partial class AuthForm : MaterialForm
    {
        AppDbContext db;
        public AuthForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            //Активация дизайна
            DesignActive();
        }
        //Дизайн
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.Cyan900, Primary.Cyan900, Accent.DeepOrange700, TextShade.WHITE);
        }
        //Кнопка выхода из программы
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Переход на страницу покупателя
        private void ToUIButton_Click(object sender, EventArgs e)
        {
            var ui = new UserI(db);
            ui.Show();
            this.Hide();
        }
        //Переход на страницу администратора
        private void ToAIButton_Click(object sender, EventArgs e)
        {
            var ai=new AdminI(db);
            ai.Show();
            this.Hide();
        }
    }
}
