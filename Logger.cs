using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Comandos
{
    internal class Logger
    {
        public void Log(string message)
        {
            string write = $"../.././loggs/exmple {DateTime.Today:yyyy-MM-dd} .txt";
            //string txt = "hllow world" + System.DateTime.Now;
            File.WriteAllText(write, message);
        }
        
    }
}
