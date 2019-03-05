using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = args[0];
            string param = args[1];

            CommandProcessor.ProcessCommand(command, param);
            Console.ReadLine();
        }
    }
}
