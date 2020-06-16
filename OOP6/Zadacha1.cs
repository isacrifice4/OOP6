using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Zadacha1
    {
        public int numb1;
        public int numb2;
        public Zadacha1()
        {

        }
        public Zadacha1(int number)
        {
            numb1 = number;
        }
        public Zadacha1(int number, int number2)
        {
            numb1 = number;
            numb2 = number2;
        }
        public void Print()
        {
            Console.WriteLine(numb1 + " | " + numb2);
        }
    }
}
