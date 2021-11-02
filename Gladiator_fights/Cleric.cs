using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator_fights
{
    class Cleric : Character
    {
        public Cleric (string name, int health, int damage) : base(name, health, damage)
        {
            if (Health> 200)
                Health -= 100;
            else Health -= 50;
            _damage += 20;
        }
        public override void TakeDamage(Character char12)
        {
            Heal(char12);
            base.TakeDamage(char12);
        }
        public void Heal(Character char12)
        {
            Console.WriteLine(_name + " лечится");
            Health += char12._damage - char12._damage / 2;
        }
    }
}