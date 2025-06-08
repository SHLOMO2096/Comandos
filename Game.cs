
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Game
    {
        private WeaponFactory weaponFactory = new WeaponFactory();
        private EnemyFactory enemyFactory = new EnemyFactory();
        private ComandoFactory comandoFactory = new ComandoFactory();

        public Game(WeaponFactory weaponFactory, EnemyFactory enemyFactory, ComandoFactory comandoFactory)
        {
            weaponFactory = new WeaponFactory();
            enemyFactory = new EnemyFactory();
            comandoFactory = new ComandoFactory();
        }
    }
}
