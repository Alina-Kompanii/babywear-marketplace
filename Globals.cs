using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace крокодил
{
    public static class Globals
    {
        public static List<string> CartItems = new List<string>();

        // Словарь для хранения цен товаров в корзине (ключ - имя товара, значение - цена)
        public static Dictionary<string, decimal> CartPrices = new Dictionary<string, decimal>();

        // Общая сумма корзины
        public static decimal TotalPrice = 0;


    }
}
