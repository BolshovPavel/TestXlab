using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    internal class Program
    {
        class House
        {
            public string street;
            public float number;

            public void Print()
            {
                Console.WriteLine($"{street}, {number}");
            }
        }
        static void Main(string[] args)
        { 

            House tower = new House();
            tower.street = "Ладно, оставим это пасхалкой если кто-то и будет читать";
            tower.number = 1125333f;

            tower.Print();
        }
    }
}
