using System;
using System.Linq;


namespace Exercise_3
{
    class dbPrice
    {
        Price[] prices = new Price[2];
        Price price;
        int counter = 0;

        protected Price[] AddPrice()
        {
            Console.WriteLine("Введите наименование товара");
            string product_name = Console.ReadLine();
            Console.WriteLine("Введите наименование магазина");
            string store_name = Console.ReadLine();
            Console.WriteLine("Введите цену товара гривнах");
            double product_price = Convert.ToDouble(Console.ReadLine());
            price = new Price(product_name, store_name, product_price);

            if (counter < prices.Length)
            {
                prices[counter] = price;
                counter++;
            }
            else
            {
                prices = prices.OrderBy(shop => shop.StoreName).ToArray();
                Console.WriteLine($"Вы ввели максимальное число товаров - {counter}");
                Console.WriteLine();
                Console.ReadKey();
            }
            return prices;
        }

        protected void ReadAll()
        {
            var result = prices.Where(shop => !string.IsNullOrEmpty(shop.StoreName)).OrderBy(shop => shop.StoreName).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine("\n" + item + "\n");
            }
            Console.ReadKey();
        }

        protected void ProductInformation()
            {
            Console.WriteLine("Введите наименование магазина:");
            string store_name = Console.ReadLine();
            foreach (Price shop in prices)
            {
                if (shop.StoreName.Contains(store_name))
                {
                    var result = from product in prices
                                 where product.StoreName == store_name
                                 select product.ProductName + "-" + product.ProductPrice + " UAH";
                    foreach (var item in result)
                    {
                        Console.WriteLine("\n"+item + "\n");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
    
}
