using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class ComandoFactory
    {
        public List<Comando> Comandos { get; private set; } = new List<Comando>();
        public void createComando(string name, string nameid, string typeComando)
        {
            switch (typeComando)
            {
                case "comando":
                    Comando comando =  new Comando(name, nameid);
                    Comandos.Add(comando);
                    break;
                case "aircomando":
                    AirCommando aircomando = new AirCommando(name, nameid);
                    Comandos.Add(aircomando);
                    break ;
                case "seacomando":
                    SeaCommando seacommando = new SeaCommando(name, nameid);
                    Comandos.Add(seacommando);
                    break;

            }
            
        }
    }
}
