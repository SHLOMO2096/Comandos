using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{

    enum Tool
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
        protected string Name { get; set; }
        protected int NameId;
        protected Tool[] Tools = { Tool.Hammer, Tool.Chisel, Tool.Rope, Tool.WaterBag }; 
        protected strStatus CurrentStatus { get; set; }

        public Comando(string name, int nameId, strStatus currentStatus)
        {
            Name = name;
            NameId = nameId;
            CurrentStatus = currentStatus;
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

        public void Attack()
        {
            Console.WriteLine($"{NameId} is now Attack.");
        }

        public void print()
        {
            Console.WriteLine($"Name: {Name}, ID: {NameId}, Status: {CurrentStatus}");
            Console.WriteLine("Tools available:");
            foreach (var tool in Tools)
            {
                Console.WriteLine($"- {tool}");
            }
        }

    }
}
