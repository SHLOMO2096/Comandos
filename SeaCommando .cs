using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class SeaCommando : Comando
    {
        public SeaCommando(string name, string nameId) : base(name, nameId) { }

        public void Swim()
        {
            Console.WriteLine($"{NameId} is now swimming.");
        }
        public override string Attack()
        {
            return $"{NameId} is now attacking from the see.";
        }


    }
}
