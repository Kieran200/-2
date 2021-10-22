using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator_Fights
{
    class Character
    {
        private int _health;
        private int _damage;
        private string _name;
        public Character(string name, int h, int d)
        {
            _name = name;
            _health = h;
            _damage = d;
        }
        public static void Attack1(Character r, Character t)
        {
            Characteristic(r, t);
            while (t._health > 0 && r._health > 0)
            {
                Kick1(r, t);
                if (r._health < 0) continue;
                Kick2(r, t);
            }
            Message(r, t);
        }
        private static void Characteristic(Character r, Character t)
        {
            Console.WriteLine(r._name + " Здоровье: " + r._health + " Урон: " + r._damage);
            Console.WriteLine(t._name + " Здоровье: " + t._health + " Урон: " + t._damage);
        }
        private static void Message(Character r, Character t)
        {
            if (r._health < 0)
                Console.WriteLine("Победил " + t._name);
            else Console.WriteLine("Победил " + r._name);
        }
        private static void Kick1(Character r, Character t)
        {
            r._health = r._health - t._damage;
            Console.WriteLine("Персонаж " + t._name + " наносит урон персонажу " + r._name);
            Console.WriteLine(t._name + ": здоровье: " + t._health);
            Console.WriteLine(r._name + ": здоровье: " + r._health);
        }
        private static void Kick2(Character r, Character t)
        {
            t._health = t._health - r._damage;
            Console.WriteLine("Персонаж " + r._name + " наносит урон персонажу " + t._name);
            Console.WriteLine(t._name + ": здоровье: " + t._health);
            Console.WriteLine(r._name + ": здоровье: " + r._health);
        }
    }
}
