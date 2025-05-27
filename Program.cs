using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comando asher = new Comando("asher", 22, strStatus.Standing);
            asher.print();
            asher.Walk();
            //asher.print();
            asher.Hide();
            //asher.print();
            asher.Attack();
            //asher.print();

        }
    }
}
