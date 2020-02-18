using System;
using System.Linq;

namespace PizzaTrade
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (PizzaTradeDBContext db = new PizzaTradeDBContext())
            {
                // получаем объекты из бд и выводим на консоль
                var customers = db.Customers.ToList();
                Console.WriteLine("Список клиентов:");
                Console.WriteLine("Номер.Имя - Адрес - Телефон");
                foreach (Customers cu in customers)
                {
                    Console.WriteLine($"{cu.Id}.{cu.CustomerName} - {cu.Address} - {cu.Phone}");
                }
                Console.ReadKey();

                var orders = db.Orders.ToList();
                Console.WriteLine("Список заказов:");
                Console.WriteLine("Номер - ДатаОформления - Сумма");
                foreach (Orders ord in orders)
                {
                    Console.WriteLine($"{ord.Id} - {ord.DateCreated} - {ord.Amount}");
                }
                Console.ReadKey();

                var pizzas = db.Pizzas.ToList();
                Console.WriteLine("Список пиццы:");
                Console.WriteLine("Номер.Наименование - Диаметр - Вес - Цена");
                foreach (Pizzas piz in pizzas)
                {
                    Console.WriteLine($"{piz.Id}.{piz.PizzaName} - {piz.Diameter} - {piz.Weight} - {piz.Price}");
                }
                Console.ReadKey();
            }
            Console.WriteLine("Hello World!");
                       
        }
    }
}
