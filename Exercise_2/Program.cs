using System;


namespace Exercise_2
{
    class Program
    {
        static Menu menu = new Menu();
        static void Main(string[] args)
        {
            //Worker worker = new Worker("Голубев Денис", "Менеджер",  new DateTime(2014,05,15));
            //Console.WriteLine(worker);
            menu.SelectMenuItem();
            Console.ReadKey();
        }
    }
}
