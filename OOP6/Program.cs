using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Program
    {
       
            static void Main(string[] args)
            {
                Zadacha1 argument = new Zadacha1();
                argument.Print();
                Zadacha1 argument1 = new Zadacha1(123);
                argument1.Print();
                Zadacha1 argument2 = new Zadacha1(1234, 4321);
                argument2.Print();

                Console.WriteLine("");
                Console.WriteLine("_______________________________");
                Console.WriteLine("");

                Zadacha2 text1 = new Zadacha2();
                Zadacha2 text2 = new Zadacha2();
                Zadacha2 text3 = new Zadacha2();
                text1.Write();
                text1.Print();
                text2.Write("Привет мир");
                text2.Print();
                text3.Write("Hello world!");
                text3.Print();

                Console.WriteLine("");
                Console.WriteLine("_______________________________");
                Console.WriteLine("");

                Zadacha3 triangle = new Zadacha3(32, 7, 15);
                Console.WriteLine("_______________________________");
                Zadacha3 triangle2 = new Zadacha3(23, 6, 20);

                Console.WriteLine("");
                Console.WriteLine("_______________________________");
                Console.WriteLine("");

                Console.ReadLine();
            }
    }
    
}
