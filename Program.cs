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
            //Comando asher = new Comando("asher", "ERTYU");
            //AirCommando airCommando = new AirCommando("Air Commando", "AIR001");
            //SeaCommando seaCommando = new SeaCommando("Sea Commando", "SEA001");

            //Comando [] arrComando = new[] { asher, airCommando, seaCommando };
            ////Console.WriteLine(arrComando.GetType());
            ////Console.WriteLine(arrComando.Length);
            //Console.WriteLine( airCommando.Attack());
            //foreach (Comando item in arrComando)
            //{
            //    Console.WriteLine( item.Attack());
            //} 
          
            //Weapon weapon = new Weapon("AK-47", "Automatic Rifle", 30);
           


            EnemyFactory oi = new EnemyFactory();
            Enemy myEnemy = oi.CreateEnemy("Enemy2");
            EnemyFactory oit = new EnemyFactory();
            Enemy myEnemy1 = oi.CreateEnemy("Enemy3");
            Console.WriteLine(myEnemy.ToString());
            Console.WriteLine(myEnemy1.ToString());
            ComandoFactory comandoFactory = new ComandoFactory();
            comandoFactory.createComando("avrham", "yui4566", "aircomando");


            Logger logger = new Logger();
            logger.Log("xxxxxxxxxxxxxxoooooooooooooo");
        }
    }
}
