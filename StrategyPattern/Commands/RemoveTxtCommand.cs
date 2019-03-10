using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RemoveTxtCommand: ICommand
    {
        public void Process(string param)
        {
            if (!Directory.Exists(param))
            {
                Console.WriteLine("directory {0} doesn't exist", param);
                return;
            }

            File.Delete(param + "\\test.txt");
        }
    }
}
