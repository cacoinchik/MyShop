using System;
using MaterialSkin.Controls;
using MaterialSkin;
using DbLibrary;
using DbLibrary.Models;
using System.Linq;
using System.Windows.Forms;

namespace MyShop
{
    public partial class AdminI : MaterialForm
    {
        AppDbContext db;
        public AdminI(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            //Активация дизайна
            DesignActive();
        }
        private void AdminI_Load(object sender, EventArgs e)
        {
            UpdateTable();
            SaveButton.Visible = false;
            TypeBox.SelectedIndex= 0;
        }
        //Дизайн
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.Cyan900, Primary.Cyan900, Accent.DeepOrange700, TextShade.WHITE);
        }
        //Добавить товар
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm(db);
            form.ShowDialog();
            UpdateTable();
        }
        //Кнопка выхода из аккаунта
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var auth = Application.OpenForms[0];
            auth.Show();
            Close();
        }
        //Удалить товар
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ProductsView.CurrentRow;
            int id=(int)row.Cells["ProductId"].Value;
            Product product=db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
            UpdateTable();
        }
        //Метод обновления таблиц
        private void UpdateTable()
        {
            ProductsView.DataSource = db.Products.ToList<Product>();
            ChecksView.DataSource=db.Checks.ToList<Check>();
        }

        //Изменить товар
        private void ChangeProductButton_Click(object sender, EventArgs e)
        {
            SaveButton.Visible = true;
            DataGridViewRow row = ProductsView.CurrentRow;
            int id = (int)row.Cells["ProductId"].Value;
            Product product = db.Products.Find(id);
            if(product != null)
            {
                NameBox.Text=product.Name;
                FirmBox.Text=product.Firm;
                PriceBox.Text= product.Price.ToString();
                CountBox.Text= product.Count.ToString();
                DescBox.Text = product.Description;
                TypeBox.Text= product.Type.ToString();
            }
        }
        //Сохранить изменения
        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ProductsView.CurrentRow;
            int id = (int)row.Cells["ProductId"].Value;
            Product product = db.Products.Find(id);
            if(product!= null)
            {
                product.Name = NameBox.Text;
                product.Firm = FirmBox.Text;
                product.Price = PriceBox.Value;
                product.Count = Convert.ToInt32(CountBox.Value);
                product.Description=DescBox.Text;
                product.Type= TypeBox.Text;
            }
            NameBox.Text = null;
            FirmBox.Text= null;
            PriceBox.Text= null;
            CountBox.Text= null;
            DescBox.Text= null;
            TypeBox.SelectedIndex=0;
            UpdateTable();
            db.SaveChanges();
            SaveButton.Visible=false;

        }
        //Выход из аккаунта
        private void AdminI_FormClosed(object sender, FormClosedEventArgs e)
        {
            var auth = Application.OpenForms[0];
            auth.Show();
        }
        //Метод выдачи заказа
        private void EndOrderButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ChecksView.CurrentRow;
            int id = (int)row.Cells["CheckId"].Value;
            Check check=db.Checks.Find(id);
            if (check!=null)
            {
                db.Checks.Remove(check);
            }
            db.SaveChanges();
            UpdateTable();
        }
    }
}
