using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Weapon
    {
        protected string Name { get; set; }
        protected string MenuFactor { get; set; }
        protected int NmofWeapons { get; set; }

        public Weapon(string name, string menuFactor, int nmofWeapons)
        {
            Name = name;
            MenuFactor = menuFactor;
            NmofWeapons = nmofWeapons;
        }

        public void shoot()
        {
            if (NmofWeapons > 0)
            {
                NmofWeapons--;
                Console.WriteLine("booommm");
                Console.WriteLine($"Remaining {NmofWeapons} Balls ");
            }
            else
            {
                Console.WriteLine("The cartridge is empty. Please replace the cartridge.");
            }
        }
    }
}
