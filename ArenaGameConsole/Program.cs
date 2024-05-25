using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArenaGameEngine
{
    // Mage class that uses fire magic and spends mana for powerful attacks
    public class Mage : Hero
    {
        public Mage() : this("Default Mage") // By default, all mages are named 'Default Mage'
        {

        }

        public Mage(string name) : base(name) // A named mage, we supply the name
        {
            Mana = 150; // Initial mana
        }

        public int Mana { get; private set; }

        public override int Attack()
        {
            if (Mana >= 50) // Check if there is enough mana for a powerful attack
            {
                Mana -= 50; // Reduce mana after the attack
                int damage = 80; // Define the damage from the fire spell
                return damage;
            }
            else
            {
                Console.WriteLine($"{Name} doesn't have enough mana for a powerful attack. Using a weaker spell.");
                return base.Attack(); // Use the base attack if there is not enough mana
            }
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage); // Take damage as per the base Hero class
        }
    }
}
