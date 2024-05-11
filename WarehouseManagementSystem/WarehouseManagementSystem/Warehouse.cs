using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem
{
    public class Warehouse
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private List<Product> products;

        public Warehouse()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            log.Info($"Товар \"{product.Name}\" добавлен на склад.");
        }

        public void RemoveProduct(Product product)
        {
            if (products.Remove(product))
            {
                log.Info($"Товар \"{product.Name}\" удален со склада.");
            }
            else
            {
                log.Warn($"Товар \"{product.Name}\" не найден на складе.");
            }
        }

        public void DisplayProducts()
        {
            log.Info("Список товаров на складе:");
            foreach (var product in products)
            {
                log.Info($"- {product.Name} (Код: {product.Code}, Цена: {product.Price}, Количество: {product.Quantity})");
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

