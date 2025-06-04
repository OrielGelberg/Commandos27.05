using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos27._05
{
    internal class EnemyFactory
    {
        List<Enemy> enemies = new List<Enemy>();
        public EnemyFactory() { }
        public Enemy CreateEnemy(string name)
        {
            Enemy enemy = new Enemy(name);
            enemies.Add(enemy);
            Console.WriteLine($"Enemy {name} has been created.");
            return enemy;
        }

        public List<Enemy> GetAllEnemies()
        {
            return new List<Enemy>(enemies);
        }

        public int GetEnemyCount()
        {
            return enemies.Count;
        }
    }
}
