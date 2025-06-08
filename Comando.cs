using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{

    enum Tools
    {
        Hammer,
        Chisel,
        Rope,
        WaterBag,
    }
    enum strStatus
    {
        Standing,
        Walking,
        Hiding,
    }

    internal class Comando
    {
        private string Name;
        protected string NameId { get; set; }
        protected Tools[] tools = { Tools.Hammer, Tools.Chisel, Tools.Rope, Tools.WaterBag, };
        protected strStatus CurrentStatus;

        public Comando(string name, string nameId)
        {
            Name = name;
            NameId = nameId;
            CurrentStatus = strStatus.Standing;
        }

        public void Walk()
        {
            CurrentStatus = strStatus.Walking;
            Console.WriteLine($"{Name} is now walking.");
        }

        public void Hide()
        {
            CurrentStatus = strStatus.Hiding;
            Console.WriteLine($"{Name} is now Hiding.");
        }

        public virtual string Attack()
        {
            return $"{NameId} is now Attack.";
        }

        public void print()
        {
            Console.WriteLine($"Name: {Name}, ID: {NameId}, Status: {CurrentStatus}");
            Console.WriteLine("Tools available:");
            foreach (var tool in tools)
            {
                Console.WriteLine($"- {tool}");
            }

        }
        public string SayName(string commanderRank)
        {
            if (commanderRank == "general")
            {
                return Name;
            }
            else if (commanderRank == "colonel" )
            {
                return NameId;
            }
            else
            {
                return "You are not authorized to see the name or ID.";
            }
        }


    }
}
