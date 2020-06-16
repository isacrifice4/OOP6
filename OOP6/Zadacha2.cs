using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Zadacha2
    {
        private string line = "Пусто";
        public void Write()
        {

        }
        public void Write(string line2)
        {
            if (line2.Length > 10) line = "Слишком длинная строка";
            else line = line2;
        }
        public void Print()
        {
            Console.WriteLine(line);
        }
    }
}
