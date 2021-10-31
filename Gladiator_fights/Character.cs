using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator_fights
{
    class Character
    {
        private int _health;
        public int _damage;
        Random rnd = new Random();
        public Character()
        {
            _health = rnd.Next(100, 300);
            _damage = rnd.Next(20, 40);
        }
        public static void Attack1(Character first, Character second)
        {
            Characteristic(first, second);
            while (first._health > 0 && first._health > 0)
            {
                TakeDamage(first, second);
                if (first._health > 0)
                    TakeDamage(first, second);
                else continue;
            }
            Winner(first, second);
        }
        public virtual void TakeDamage(Character first, Character second)
        {
            first._health = first._health - second._damage;
            Console.WriteLine("Персонаж " + second + " наносит урон персонажу " + first);
            Console.WriteLine(second + ": здоровье: " + second);
            Console.WriteLine(first + ": здоровье: " + first);
        }
        private static void Winner(Character first, Character second)
        {
            if (first._health <= 0)
                Console.WriteLine(second + " победил!!!");
            else Console.WriteLine(first + " победил!!!");
        }
        private static void Characteristic(Character first, Character second)
        {
            Console.WriteLine(first + " Здоровье: " + first._health + " Урон: " + first._damage );
            Console.WriteLine(t + " Здоровье: " + second._health + " Урон: " + second._damage);
        }
    }
}
