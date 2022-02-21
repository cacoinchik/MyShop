using System;
using MaterialSkin.Controls;
using MaterialSkin;
using DbLibrary;
using DbLibrary.Models;
using System.Linq;

namespace MyShop
{
    public partial class AddProductForm : MaterialForm
    {
        public Product p { get; set; }
        AppDbContext db;
        public AddProductForm(AppDbContext db)
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
        //Кнопка сохранить товар
        private void SaveButton_Click(object sender, EventArgs e)
        {
            p=new Product();
            p.Name = NameBox.Text;
            p.Firm = FirmBox.Text;
            p.Price = PriceBox.Value;
            p.Count = Convert.ToInt32(CountBox.Value);
            p.Description = DescriptionBox.Text;
            p.Type= TypeBox.Text;
            db.Products.Add(p);
            db.SaveChanges();
            Close();
        }
    }
}
