using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator_fights
{
    class Tank : Character
    {
        Random rnd = new Random();

        public Tank (string name, int health, int damage): base (name, health, damage)
        {
            Health += 100;
        }
        public override void TakeDamage(Character char12)
        {
            bool defend = Convert.ToBoolean(rnd.Next(0, 2));
            if (defend == true)
            {
                Console.WriteLine(_name + " использует защиту");
                Health = Health + Protect(char12);
            }
            
            base.TakeDamage(char12);   
        }

        public int Protect(Character char12)
        {
            int damage1 = char12._damage;
            damage1 = damage1 / 2;
            return damage1;
        }  
    }
}
