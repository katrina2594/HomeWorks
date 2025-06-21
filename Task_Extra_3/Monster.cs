using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Extra_3
{
    class Monster: Character
    {
        public Monster()
            : base("Злобный гоблин", 20, 0) { }
        public override void Attack(Character target)
        {
            int damage = new Random().Next(1, 7);
            target.Health -= damage;
            Console.WriteLine($"{Name} наносит {damage} урона {target.Name}");
        }
    }

}
