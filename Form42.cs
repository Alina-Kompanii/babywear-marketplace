using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крокодил
{
    public partial class Form42 : Form
    {
        private string productName = "Чемодан детский, черно-белый"; // Название товара
        private decimal productPrice = 4500.00m; // Цена товара
        public Form42()
        {
            InitializeComponent();
            label1.Text = productName;
            label3.Text = productPrice.ToString("C");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.CartItems.Add(productName); // Добавляем имя товара в список
            Globals.CartPrices.Add(productName, productPrice); // Добавляем имя товара и цену в словарь
            Globals.TotalPrice += productPrice;

            MessageBox.Show($"Товар '{productName}' добавлен в корзину.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
