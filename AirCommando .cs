using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class AirCommando : Comando
    {
        public AirCommando(string name, string nameId) : base(name, nameId) {}

        public void Fly()
        {
            Console.WriteLine($"{NameId} is now flying.");
        }

        public override string Attack() 
        {
            return $"{NameId} is now attacking from the air.";
        }
    }
    
        
    
    
    
}
