using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    enum MenuItem
    {
        Add = 1,
        Read,
        WorkExperience,
        Exit
    }
    class Menu
    {
        dbWorker worker = new dbWorker();
        private void MyMenu(int menu_number)
        {
            MenuItem item = (MenuItem)menu_number;
            switch (item)
            {
                case MenuItem.Add:
                    {
                        worker.AddWorkers();
                        break;
                    }
               case MenuItem.Read:
                    {
                        worker.ReadAll();
                        break;
                    }
                case MenuItem.WorkExperience:
                    {
                        worker.WorkExperience();
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
                Console.WriteLine("Выберите пункт меню:\n1 - Добавить сотрудника\n2 - Список сотрудников\n3 - Отбор сотрудников по стажу\n4 - Выход из программы");

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
