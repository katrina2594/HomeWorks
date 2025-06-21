using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Extra_3
{
    class Player:Character 
    {
        public int Potion { get; set; }
        public Player(string name)
            : base(name,20,5)
        {
            Potion = 3;
        }
        public void UseHealthPotion()
        {
            if (Health > 0)
            {
                Health += 10;
                Potion--;
                Console.WriteLine($"{Name} использовал зелье здоровья. Здоровье: {Health}");
            }
            else
            {
                Console.WriteLine($"{Name} зелий нет, но вы держитесь. Здоровье: {Health}");
            }
        }

    }
}
