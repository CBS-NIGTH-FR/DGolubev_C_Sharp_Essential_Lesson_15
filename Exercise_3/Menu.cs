using System;

namespace Exercise_3
{
    enum MenuItem
    {
        Add = 1,
        Read,
        ProductInformation,
        Exit
    }
    class Menu: dbPrice
    {
        private void MyMenu(int menu_number)
        {
            MenuItem item = (MenuItem)menu_number;
            switch (item)
            {
                case MenuItem.Add:
                    {
                        AddPrice();
                        break;
                    }
               case MenuItem.Read:
                    {
                        ReadAll();
                        break;
                    }
                case MenuItem.ProductInformation:
                    {
                        ProductInformation();
                        break;
                    }
                case MenuItem.Exit:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
        public void SelectMenuItem()
        {
            while (true)
            {
                Console.WriteLine("Выберите пункт меню:\n1 - Добавить товар\n2 - Список товаров\n3 - Список товаров по магазину\n4 - Выход из программы");

                try
                {
                    int number_item = Convert.ToInt32(Console.ReadLine());
                    MyMenu(number_item);
                }
                catch
                {
                    Console.WriteLine("Вы ввели не правильный номер меню");
                    Console.ReadKey();
                }

                Console.Clear();
            }
        }
    }
}
