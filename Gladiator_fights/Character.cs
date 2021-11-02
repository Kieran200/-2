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
        public string _name { get; }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (Health < 0)
                    _health = 0;
            }
        }
        public Character(string name, int health, int damage)
        {
            Health = health;
            _damage = damage;
            _name = name;
        }
        public void Attack1(Character char1)
        {
            TakeDamage(char1);
        }
        public virtual void TakeDamage(Character char12)
        {
            Health = Health - char12._damage;
            Console.WriteLine("Персонаж " + _name + " получает урон");
            Console.WriteLine(_name + ": здоровье: " + Health);
        }

        public void Characteristic()
        {
            Console.WriteLine(_name + " Здоровье: " + Health + " Урон: " + _damage);
        }
    }
}
