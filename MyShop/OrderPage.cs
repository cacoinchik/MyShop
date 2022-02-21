using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using DbLibrary.Models;
using DbLibrary;
using System;

namespace MyShop
{
    public partial class OrderPage : MaterialForm
    {
        public decimal sum;
        AppDbContext db;
        public OrderPage(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
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
        //Оформление заказа
        private void OrderButton_Click(object sender, System.EventArgs e)
        {
            if (NameBox.Text.Length == 0 || PhoneBox.Text.Length == 0)
                MessageBox.Show("Заполните обязательные поля");
            else
            {
                Pay();
                MessageBox.Show("Ваш заказ оформлен!\nЖдём вас на выдачу товара завтра с 8:00 до 21:00\nНе забудьте телефон,он нужен для проверки заказа!");
                var ui = Application.OpenForms[1];
                ui.Activate();
                Close();
            }
        }
        //Метод оплаты
        private void Pay()
        {
            Check check = new Check();
            check.Name = NameBox.Text;
            check.Surename = SurenameBox.Text;
            check.Phone = PhoneBox.Text;
            check.Date = DateTime.Now.ToString();
            check.Price = sum;
            string orderlist = null, name = null, firm = null, count = null;
            foreach (Cart cart in db.Carts)
            {
                name = cart.Name;
                firm = cart.Firm;
                count = cart.Count.ToString();
                orderlist = orderlist + String.Format("{0} {1} в количестве {2} штук", firm, name, count);
                db.Carts.Remove(cart);
            }
            check.OrderList = orderlist;
            db.Checks.Add(check);
            db.SaveChanges();
        }

        //Отказ от покупки
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            var ui = Application.OpenForms[1];
            ui.Show();
            Close();
        }
        //Выход 
        private void OrderPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ui = Application.OpenForms[1];
            ui.Show();
        }
    }
}
