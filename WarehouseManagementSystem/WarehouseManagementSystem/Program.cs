using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.Reflection;
using System.IO;
using System.Security.Principal;

namespace WarehouseManagementSystem
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            // Инициализация log4net из файла конфигурации
            XmlConfigurator.Configure(new FileInfo("log4net.config"));

            // Пример использования логгирования
            log.Info("Программа управления складом запущена.");

            Warehouse warehouse = new Warehouse();

            // Добавление товаров на склад
            Product product1 = new Product { Name = "Лампа", Code = "001", Price = 10.99m, Quantity = 50 };
            Product product2 = new Product { Name = "Стол", Code = "002", Price = 150.99m, Quantity = 20 };

            warehouse.AddProduct(product1);
            warehouse.AddProduct(product2);

            // Вывод списка товаров на складе
            warehouse.DisplayProducts();

            // Удаление товара со склада
            warehouse.RemoveProduct(product1);

            // Вывод обновленного списка товаров на складе
            warehouse.DisplayProducts();

            log.Info("Программа управления складом завершена.");

            Console.ReadLine(); // Ожидание нажатия клавиши для завершения программы
        }
    }
}
