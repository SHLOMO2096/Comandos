
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class WeaponFactory
    {
        public List<Weapon> weapons { get; private set; } = new List<Weapon>();
        public void createWeapon(string name, string menuFactor, int nmofWeapons)
        {
            Weapon weapon = new Weapon(name, menuFactor, nmofWeapons);
            weapons.Add(weapon);
        }
    }
}
