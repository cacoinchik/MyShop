using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using DbLibrary;
using DbLibrary.Models;
using System.Linq;

namespace MyShop
{
    public partial class UserI : MaterialForm
    {
        AppDbContext db;
        public UserI(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;      
            //Активация дизайна
            DesignActive();
        }
        private void UserI_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
        //Выход с аккаунта
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var auth = Application.OpenForms[0];
            auth.Show();
            Close();
        }
        //Кнопка увелечения количества
        private void PlusButton_Click(object sender, EventArgs e)
        {
            int count=int.Parse(CountBox.Text);
            count++;
            CountBox.Text= count.ToString();
        }
        //Кнопка уменьшения количества
        private void MinusButton_Click(object sender, EventArgs e)
        {
            int count = int.Parse(CountBox.Text);
            if (count <= 1)
            {
                MessageBox.Show("Нельзя добавить товара меньше чем 1");
                count = 1;
            }
            else
                count--;
            CountBox.Text= count.ToString();
        }
        //Кнопка увелечения количества
        private void PlusCButton_Click(object sender, EventArgs e)
        {
            int count = int.Parse(CountCBox.Text);
            count++;
            CountCBox.Text = count.ToString();
        }
        //Кнопка уменьшения количества
        private void MinusCButton_Click(object sender, EventArgs e)
        {
            int count = int.Parse(CountCBox.Text);
            if (count <= 1)
            {
                MessageBox.Show("Нельзя удалить товара меньше чем 1");
                count = 1;
            }
            else
                count--;
            CountCBox.Text= count.ToString();
        }
        //Добавление товара в корзину
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row= ProductsView.CurrentRow;
            int id = (int)row.Cells["ProductId"].Value;
            Product product = db.Products.Find(id);
            string name=product.Name;
            string firm=product.Firm;
            string type=product.Type;
            int prodcutid = product.ProductId;
            decimal price=product.Price;
            int count = int.Parse(CountBox.Text);

            if (count > product.Count)
            {
                MessageBox.Show("На складе недостаточно товара");
            }
            else
            {
                int newcount = product.Count;
                newcount = newcount - count;
                product.Count = newcount;
                var item = db.Carts.Where(i => i.ProductId == id);

                if (item.Count() == 0)
                {
                    AddProduct(name, firm, type, prodcutid, price, count);
                }
                else
                {
                    foreach (Cart cart in item)
                    {
                        int cartcount = cart.Count;
                        cartcount = cartcount + count;
                        cart.Count = cartcount;
                    }
                }
                CountBox.Text = 1.ToString();
                CountCBox.Text = 1.ToString();
                db.SaveChanges();
                OrderSum();
                UpdateTable();
            }
            
        }
        //Метод добавления товара в корзину
        private void AddProduct(string name,string firm,string type,int productid,decimal price,int count)
        {
            Cart cart=new Cart();
            cart.Name = name;
            cart.Firm = firm;
            cart.Type = type;
            cart.Price = price;
            cart.Count = count;
            cart.ProductId = productid;
            db.Carts.Add(cart);
        }
        //Обновление таблиц
        private void UpdateTable()
        {
            ProductsView.DataSource=db.Products.ToList<Product>();
            CartView.DataSource = db.Carts.ToList<Cart>();
            OrderSumLabel.Text=OrderSum().ToString();
            SelectTypeBox.SelectedIndex=0;
        }
        //Дизайн
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.Cyan900, Primary.Cyan900, Accent.DeepOrange700, TextShade.WHITE);
        }
        //Кнопка удаления товара из корзины
        private void DeleteFromCartButton_Click(object sender, EventArgs e)
        {
            if (db.Carts.Count() ==0)
                MessageBox.Show("Ваша корзина пуста");
            else
            {
                DataGridViewRow row = CartView.CurrentRow;
                int id = (int)row.Cells["CartId"].Value;
                Cart cart=db.Carts.Find(id);
                int productid =cart.ProductId;
                int count = cart.Count;
                int checkcount = int.Parse(CountCBox.Text);
                if (checkcount > count)
                    MessageBox.Show("У вас нет такого количества товара в корзине");
                else if (checkcount == count)
                {
                    db.Carts.Remove(cart);
                    BackCount(checkcount,productid);
                }
                else if (checkcount < count)
                {
                    count = count - checkcount;
                    cart.Count = count;
                    BackCount(checkcount,productid);
                }
                db.SaveChanges();
                UpdateTable();
                CountCBox.Text = 1.ToString();
            }

        }
        //Метод для обновления количества товара после удаления из корзины
        private void BackCount(int backcount,int id)
        {
            Product product=db.Products.Find(id);
            int count=product.Count;
            count = count + backcount;
            product.Count = count;
        }
        //Вычисление суммы заказа
        private decimal OrderSum()
        {
            decimal sum = 0;
            foreach(var item in db.Carts)
            {
                sum = sum + (decimal)(item.Price * item.Count);
            }
            return sum;
        }
        //Выбор товара по категории
        private void SelectTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectTypeBox.SelectedIndex >0)
                ProductsView.DataSource = db.Products.Where(i => i.Type == SelectTypeBox.SelectedItem.ToString()).ToList();
        }
        //Сброс фильтров с таблиц
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        //Диапазоны цен
        //<10000
        private void RangeButton1_Click(object sender, EventArgs e)
        {
            ProductsView.DataSource = db.Products.Where(i => i.Price < 10000).ToList();
        }
        //10000-50000
        private void RangeButton2_Click(object sender, EventArgs e)
        {
            ProductsView.DataSource = db.Products.Where(i => i.Price > 10000).Where(i => i.Price < 50000).ToList();
        }
        //>50000
        private void RangeButton3_Click(object sender, EventArgs e)
        {
            ProductsView.DataSource=db.Products.Where(i=>i.Price>50000).ToList();
        }
        //Выход из аккаунта
        private void UserI_FormClosed(object sender, FormClosedEventArgs e)
        {
            var auth = Application.OpenForms[0];
            auth.Show();
        }
        //Кнопка оформления заказа
        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (db.Carts.Count() == 0)
            {
                MessageBox.Show("Ваша корзина пуста");
            }
            else
            {
                var op = new OrderPage(db);
                op.Show();
                op.sum = OrderSum();
                this.Hide();
            }
        }
        //Событие при активации формы
        private void UserI_Activated(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
