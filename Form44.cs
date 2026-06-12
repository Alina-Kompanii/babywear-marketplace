using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крокодил
{
    public partial class PaymentForm : Form
    {
        private decimal totalPrice;
        
        public PaymentForm(decimal totalPrice)
        {
            InitializeComponent();
       
            this.totalPrice = totalPrice;

            deliveryComboBox.Items.Add("Курьерская доставка");
            deliveryComboBox.Items.Add("Самовывоз");
            deliveryComboBox.Items.Add("Пункт выдачи");
 
            deliveryComboBox.SelectedIndex = 0;
            lblTotal.Text = $"Итого: {totalPrice:C}";
            
        }

    
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Получаем данные из текстовых полей и ComboBox
            string name = nameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();
            string deliveryMethod = deliveryComboBox.SelectedItem?.ToString();
            string cardNumber = cardNumberTextBox.Text.Trim();
            string expiryDate = expiryDateTextBox.Text.Trim();

            // Валидация данных
            bool isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(nameTextBox, "Пожалуйста, введите имя.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                errorProvider1.SetError(lastNameTextBox, "Пожалуйста, введите фамилию.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phone))
            {
                errorProvider1.SetError(phoneTextBox, "Пожалуйста, введите номер телефона.");
                isValid = false;
            }
            else if (!Regex.IsMatch(phone, @"^\+?7\d{10}$") && !Regex.IsMatch(phone, @"^8\d{10}$"))
            {
                errorProvider1.SetError(phoneTextBox, "Неверный формат номера телефона. Используйте формат +7XXXXXXXXXX или 8XXXXXXXXXX."); // Проверяем формат российского номера
                isValid = false;
            }

            if (string.IsNullOrEmpty(address))
            {
                errorProvider1.SetError(addressTextBox, "Пожалуйста, введите адрес.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(deliveryMethod))
            {
                errorProvider1.SetError(deliveryComboBox, "Пожалуйста, выберите способ доставки.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(cardNumber))
            {
                errorProvider1.SetError(cardNumberTextBox, "Пожалуйста, введите номер карты.");
                isValid = false;
            }
            else if (!IsValidCardNumber(cardNumber)) // Используем функцию для проверки номера карты
            {
                errorProvider1.SetError(cardNumberTextBox, "Неверный номер карты.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(expiryDate))
            {
                errorProvider1.SetError(expiryDateTextBox, "Пожалуйста, введите срок действия карты.");
                isValid = false;
            }
            else if (!IsValidExpiryDate(expiryDate)) // Используем функцию для проверки срока действия
            {
                errorProvider1.SetError(expiryDateTextBox, "Неверный срок действия карты. Используйте формат MM/YY.");
                isValid = false;
            }

            // Если все данные корректны, продолжаем оформление заказа
            if (isValid)
            {
                // Здесь можно добавить код для проверки данных и отправки на обработку

                // Отображаем сообщение (для примера)
                MessageBox.Show($"Заказ оформлен на имя: {name} {lastName}.\n" +
                                $"Телефон: {phone}\n" +
                                $"Адрес: {address}\n" +
                                $"Способ доставки: {deliveryMethod}\n" +
                                $"Данные карты: {cardNumber} (скрыто)",
                                "Подтверждение заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, исправьте ошибки в форме.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isValid)
            {
                // Предположим, что здесь происходит успешная обработка платежа
                // (например, отправка данных на платежный шлюз и получение подтверждения)

                // Очищаем корзину
                Globals.CartItems.Clear();
                Globals.CartPrices.Clear();
                Globals.TotalPrice = 0;

                MessageBox.Show("Оплата прошла успешно! Корзина очищена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрываем форму оплаты (возвращаемся в форму корзины)
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, исправьте ошибки в форме.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidCardNumber(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber) || !Regex.IsMatch(cardNumber, @"^\d+$"))
            {
                return false; // Пустая строка или не цифры
            }

            int sum = 0;
            bool alternate = false;
            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(cardNumber[i].ToString());
                if (alternate)
                {
                    n *= 2;
                    if (n > 9)
                    {
                        n = (n % 10) + 1;
                    }
                }
                sum += n;
                alternate = !alternate;
            }
            return (sum % 10 == 0);
        }

        private bool IsValidExpiryDate(string expiryDate)
        {
            if (string.IsNullOrEmpty(expiryDate))
            {
                return false; // Пустая строка
            }

            // Проверяем формат (MM/YY)
            if (!Regex.IsMatch(expiryDate, @"^\d{2}/\d{2}$"))
            {
                return false; // Неверный формат
            }

            try
            {
                int month = int.Parse(expiryDate.Substring(0, 2));
                int year = int.Parse(expiryDate.Substring(3, 2)) + 2000; // Предполагаем, что год - 20xx
                if (month < 1 || month > 12)
                {
                    return false; // Неверный месяц
                }

                DateTime expiry = new DateTime(year, month, 1);
                if (expiry <= DateTime.Now)
                {
                    return false; // Карта просрочена
                }
                return true;
            }
            catch (Exception)
            {
                return false; // Ошибка парсинга или другая ошибка
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form43 newForm = new Form43();
            newForm.Show();
        }
    }
}
