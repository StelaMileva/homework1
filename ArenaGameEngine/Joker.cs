using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    // Joker class that focuses on deception and debuffs
    public class Joker : Hero
    {
        public Joker() : this("Default Joker") // By default, all jokers are named 'Default Joker'
        {

        }

        public Joker(string name) : base(name) // A named joker, we supply the name
        {
        }

        public override int Attack()
        {
            // Joker distracts the opponent, making them vulnerable to debuffs
            Console.WriteLine($"{Name} distracts {target.Name}, making them vulnerable to debuffs!");
            return base.Attack(); // Use the base attack for simplicity
        }

        public void Debuff(Hero target)
        {
            // Joker inflicts debuffs on the opponent
            Console.WriteLine($"{Name} inflicts debuffs on {target.Name}, making them weaker!");
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage); // Take damage as per the base Hero class
        }
    }
}