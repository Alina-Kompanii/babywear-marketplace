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
    public partial class Form43 : Form
    {
        public Form43()
        {
            InitializeComponent();
            UpdateCartDisplay();
        }

        public void UpdateCartDisplay()
        {
            // Очистите ListBox
            listBox1.Items.Clear();

            // Заполните ListBox именами товаров из корзины
            foreach (string itemName in Globals.CartItems)
            {
                listBox1.Items.Add(itemName);
            }

            // Отобразите общую сумму
            lblTotal.Text = $"Итого: {Globals.TotalPrice:C}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void tnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Получаем имя выбранного товара
                string selectedItem = listBox1.SelectedItem.ToString();

                // Удаляем товар из корзины (из всех глобальных переменных)
                Globals.CartItems.Remove(selectedItem); // Удаляем из списка имен

                // Удаляем цену товара и вычитаем ее из общей суммы
                if (Globals.CartPrices.ContainsKey(selectedItem))
                {
                    Globals.TotalPrice -= Globals.CartPrices[selectedItem]; // Вычитаем цену из общей суммы
                    Globals.CartPrices.Remove(selectedItem); // Удаляем из словаря цен
                }

                // Обновляем отображение корзины
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearCart_Click_Click(object sender, EventArgs e)
        {
            Globals.CartItems.Clear(); // Очищаем список товаров
            Globals.CartPrices.Clear(); // Очищаем словарь цен
            Globals.TotalPrice = 0;      // Обнуляем общую сумму

            // Обновляем отображение корзины
            UpdateCartDisplay();
        }

        private void btnCheckout_Click_Click(object sender, EventArgs e)
        {
            
            
            PaymentForm paymentForm = new PaymentForm(Globals.TotalPrice);
            paymentForm.ShowDialog();

            UpdateCartDisplay();
        }
    }
}   
