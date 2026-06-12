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
    public partial class Form15 : Form
    {
        private string productName = "Ползунки с жирафиками, голубой/белый цвет "; // Название товара
        private decimal productPrice = 164.00m; // Цена товара
        public Form15()
        {
            InitializeComponent();

            label3.Text = productName;
            label2.Text = productPrice.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.CartItems.Add(productName); // Добавляем имя товара в список
            Globals.CartPrices.Add(productName, productPrice); // Добавляем имя товара и цену в словарь
            Globals.TotalPrice += productPrice;

            MessageBox.Show($"Товар '{productName}' добавлен в корзину.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newForm = new Form4();
            newForm.Show();
        }
    }
}
