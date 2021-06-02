using System;
using System.Linq;

namespace Exercise_2
{
    class dbWorker
    {
        Worker[] workers = new Worker[5];
        Worker worker;
        int counter = 0;

        public Worker[] AddWorkers()
        {
            Console.WriteLine("Введите фамилию и инициалы работника");
            string fio = Console.ReadLine();
            Console.WriteLine("Введите занимаемую должность работника");
            string position = Console.ReadLine();
            Console.WriteLine("Введите дату трудоустройства работника");
            try
            {
                DateTime employment = Convert.ToDateTime(Console.ReadLine());
                worker = new Worker(fio, position, employment);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                AddWorkers();
            }
            if (counter < workers.Length)
            {
                workers[counter] = worker;
                counter++;
            }
            else
            {
                workers = workers.OrderBy(name => name.FIO).ToArray();
                Console.WriteLine($"Вы ввели максимальное число сотрудников - {counter}");
                Console.WriteLine();
            }
            return workers;
        }
        public void ReadAll()
        {
            var result = workers.Where(worker => !string.IsNullOrEmpty(worker.FIO)).OrderBy(worker => worker.FIO).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item+"\n");
            }
            Console.ReadKey();
        }
        public void WorkExperience()
        {
            DateTime now_date = DateTime.Now;
            Console.WriteLine("Введите трудовой стаж сотрудника");
            int year = Convert.ToInt32(Console.ReadLine());
            var result = workers.Where(worker => !string.IsNullOrEmpty(worker.FIO)).Where(worker => worker.Employment.AddYears(year).Year < DateTime.Now.Year).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine($"Сотрудники, стаж работы которых превышает {year} лет:\n{item}\n");
            }
            Console.ReadKey();
        }
    }
}
