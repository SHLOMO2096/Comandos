using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Enemy
    {
        public string Name{ get; set; }
        public int Life { get; private set; } = 100;
        public bool isded  { get; set; } = false;

        public Enemy(string name)
        {
            Name = name;
            screem();
        }
        public void screem()
        {
            Console.WriteLine("i am a Enemy");
        }
        public override string ToString()
        {
            return $"Enemy Name: {Name}, Life: {Life}, is Dead: {isded}";
        }
    }
}
