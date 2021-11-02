using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator_fights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string name1 = Console.ReadLine();
            Console.WriteLine();
            string name2 = Console.ReadLine();
            Random rnd = new Random();

            Character char1 = new Character(name1, rnd.Next(100, 300), rnd.Next(20, 40));
            Tank tank = new Tank(name2, rnd.Next(100, 300), rnd.Next(20, 40));
            tank.Characteristic();
            char1.Characteristic();
            while (char1.Health>0 && tank.Health>0)
            {

                char1.Attack1(tank);
                tank.Characteristic();
                char1.Characteristic();
                if (char1.Health > 0)
                {
                    tank.Attack1(char1);
                    tank.Characteristic();
                    char1.Characteristic();
                }
                else continue;
            }   
            Winner(char1, tank);

            void Winner(Character first, Character second)
            {
                if (first.Health <= 0)
                    Console.WriteLine(second._name + " победил!!!");
                else Console.WriteLine(first._name + " победил!!!");
            }


        }
    }
}