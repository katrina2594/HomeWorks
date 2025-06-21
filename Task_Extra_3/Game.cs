using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Extra_3
{
    class Game
    {
        public Player _player;
        public Monster _monster;

        public void Start()
        {
            Console.WriteLine("=== Игра 'Битва с монстром' ===\nВведите имя вашего персонажа:");
            string playerName = Console.ReadLine();
            _player = new Player(playerName);
            _monster = new Monster();
            Console.WriteLine($"Битва начинается! {_player.Name} против {_monster.Name}!");
            do
            {
                MovePlayer();
                if (!_monster.IsAlive)
                {
                    break;
                }

                MoveMonster();
                StatusForNow();
            }
            while (!_player.IsAlive || !_monster.IsAlive);
            Console.WriteLine("Битва окончена!");
            if(_player.IsAlive)
            {
                Console.WriteLine($"{_player.Name} победил! Поздравляем!");
            }
            else
            {
                Console.WriteLine($"{_monster.Name} победил!");
            }
            Console.WriteLine("Хотите сыграть снова?:\n1 - Да / 2 - Нет");
            string playerChoice2 = Console.ReadLine();
            switch (playerChoice2)
            {
                case "1":
                    Start();
                    break;
                default:
                    Console.WriteLine("До новых встреч!");
                    break;
            }
        }
        public void MovePlayer()
        {
            Console.WriteLine("Ваш ход:\n1 - Атаковать / 2 - Использовать зелье здоровья");
            string playerChoice = Console.ReadLine();
            switch (playerChoice)
            {
                case "1":
                    _player.Attack(_monster);
                    break;
                case "2":
                    _player.UseHealthPotion();
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректное значение. Ход будет пропущен.");
                    break;
            }
        }
        public void MoveMonster()
        {
            Console.WriteLine($"Ход {_monster.Name}...");
            _monster.Attack(_player);
        }
        public void StatusForNow()
        {
            Console.WriteLine("Текущее состояние:");
            Console.WriteLine($"{_player.Name}: {_player.Health} HP");
            Console.WriteLine($"{_monster.Name}: {_monster.Health} HP");
        }
    }
}
