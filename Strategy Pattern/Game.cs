using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            // Инициализация игрока с первоначальным оружием (например, меч)
            _player = new Player(new Sword());
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the game!");

            while (true)
            {
                Console.WriteLine("Choose an action: \n1. Attack \n2. Change Weapon \n3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _player.Attack();
                        break;
                    case "2":
                        ChangeWeapon();
                        break;
                    case "3":
                        Console.WriteLine("Exiting game.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        break;
                }
            }
        }

        private void ChangeWeapon()
        {
            Console.WriteLine("Choose a weapon: \n1. Sword \n2. Bow \n3. Axe");
            string weaponChoice = Console.ReadLine();

            IWeapon newWeapon = null;
            switch (weaponChoice)
            {
                case "1":
                    newWeapon = new Sword();
                    break;
                case "2":
                    newWeapon = new Bow();
                    break;
                case "3":
                    newWeapon = new Axe();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Weapon remains the same.");
                    return;
            }

            _player.SetWeapon(newWeapon);
            Console.WriteLine("Weapon changed successfully.");
        }
    }
}
