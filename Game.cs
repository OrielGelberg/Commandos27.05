using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class Game
    {
        private CommandoFactory commandoFactory;
        private EnemyFactory enemyFactory;
        private WeaponFactory weaponFactory;
        private List<Commando> activeCommandos;
        private List<Enemy> activeEnemies;
        private List<IWeapon> availableWeapons;

        public Game()
        {
            commandoFactory = new CommandoFactory();
            enemyFactory = new EnemyFactory();
            weaponFactory = new WeaponFactory();
            activeCommandos = new List<Commando>();
            activeEnemies = new List<Enemy>();
            availableWeapons = new List<IWeapon>();
        }
        public void InitializeGame()
        {
            Console.WriteLine("=== Commando Game Initialized ===");
            CreateCommandos();
            CreateEnemies();
            CreateWeapons();
            Console.WriteLine("\n=== Game Setup Complete ===\n");
        }

        private void CreateCommandos()
        {
            Console.WriteLine("\n--- Creating Commandos ---");
            activeCommandos.Add(commandoFactory.CreateCommando("commando", "John", "Shadow", Commando.Status.Waking));
            activeCommandos.Add(commandoFactory.CreateCommando("seacommando", "Mike", "Wave", Commando.Status.Standing));
            activeCommandos.Add(commandoFactory.CreateCommando("aircommando", "Tom", "Sky", Commando.Status.Hiding));
        }

        private void CreateEnemies()
        {
            Console.WriteLine("\n--- Creating Enemies ---");
            activeEnemies.Add(enemyFactory.CreateEnemy("Enemy Alpha"));
            activeEnemies.Add(enemyFactory.CreateEnemy("Enemy Beta"));
            activeEnemies.Add(enemyFactory.CreateEnemy("Enemy Gamma"));
            activeEnemies.Add(enemyFactory.CreateEnemy("Enemy Delta"));
            activeEnemies.Add(enemyFactory.CreateEnemy("Enemy Epsilon"));
        }


        private void CreateWeapons()
        {
            Console.WriteLine("\n--- Creating Weapons ---");

            // Create firearms
            availableWeapons.Add(weaponFactory.CreateFirearm("M16", "COLT", 29));
            availableWeapons.Add(weaponFactory.CreateFirearm("AK47", "KALASHNIKOV", 30));

            // Create stones
            availableWeapons.Add(weaponFactory.CreateStone("Rock", 2.5, "Gray"));
            availableWeapons.Add(weaponFactory.CreateStone("Boulder", 5.0, "Brown"));

            // Create knives
            availableWeapons.Add(weaponFactory.CreateKnife("Combat Knife", "steel", "Military Corp", "Black", 0.3));
            availableWeapons.Add(weaponFactory.CreateKnife("Tactical Blade", "iron", "Spec Ops", "Silver", 0.25));
        }

        public void StartBattle()
        {
            Console.WriteLine("\n=== BATTLE BEGINS ===");

            // Make enemies shout
            Console.WriteLine("\n--- Enemies Shouting ---");
            foreach (Enemy enemy in activeEnemies)
            {
                enemy.Shout();
            }

            // Commandos attack
            Console.WriteLine("\n--- Commandos Attacking ---");
            foreach (Commando commando in activeCommandos)
            {
                commando.Attack();
            }

            // Demonstrate weapon usage
            Console.WriteLine("\n--- Weapons Demonstration ---");
            foreach (IWeapon weapon in availableWeapons)
            {
                weapon.Use();

                // If it's breakable, show status
                if (weapon is IBreakable breakable && breakable.IsBroken())
                {
                    Console.WriteLine($"  -> {weapon.Name} is now broken!");
                }
            }
        }

        public void DisplayGameStats()
        {
            Console.WriteLine("\n=== GAME STATISTICS ===");
            Console.WriteLine($"Active Commandos: {commandoFactory.GetCommandoCount()}");
            Console.WriteLine($"Active Enemies: {enemyFactory.GetEnemyCount()}");
            Console.WriteLine($"Available Weapons: {weaponFactory.GetWeaponCount()}");
        }



    }
}
