using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    struct Worker
    {
        string fio;
        string position;
        DateTime employment;
        public string FIO => fio;
        public string Position => position;
        public DateTime Employment => employment;
        public Worker(string fio, string position, DateTime employment)
        {
            this.fio = fio;
            this.position = position;
            this.employment = employment;
        }
        public override string ToString()
        {
            return $"Фамилия - {fio}\nДолжность - {position}\nДата трудоустройства - {employment.ToString("d")}";
        }
    }
}
